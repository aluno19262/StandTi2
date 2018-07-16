using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Stand.Models;

namespace Stand.Controllers
{
    public class ViaturasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Viaturas
        public ActionResult Index()
        {
           /* var viaturas = db.Viaturas.Include(v => v.Marca);

            return View(viaturas.ToList());*/


            var listaViaturas = db.Viaturas.ToList().OrderBy(a => a.Marca);

            return View(listaViaturas);
        }
        // GET: Viaturas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Viaturas viaturas = db.Viaturas.Find(id);
            if (viaturas == null)
            {
                return HttpNotFound();
            }
            return View(viaturas);
        }

        // GET: Viaturas/Create
        public ActionResult Create()
        {
            ViewBag.ID = new SelectList(db.Compras, "ID", "NomeStand");
            return View();
        }

        // POST: Viaturas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Matricula,Marca,Modelo,Ano,TipoCombustivel,Cor,Cilindrada,Potencia,Lugares,Tipo")] Viaturas viaturas, HttpPostedFileBase uploadFotografia)
        {
            //----------
            // escrever os dados de um novo Agente na BD 

            // especificar o ID do novo Agente
            // testar se há registos na tabela dos Agentes
            // if (db.Agentes.Count()!=0){ }

            // ou então, usar a instrução TRY/CATCH
            int idNovaViatura = 0;
            try
            {
                idNovaViatura = db.Viaturas.Max(a => a.ID) + 1;
            }
            catch (Exception)
            {
                idNovaViatura = 1;
            }

            // guardar o ID do novo Agente
            viaturas.ID = idNovaViatura;

            // especificar (escolher) o nome do ficheiro
            string nomeImagem = "Viatura_" + idNovaViatura + ".jpg";

            // var. auxiliar
            string path = "";

            // validar se a imagem foi fornecida
            if (uploadFotografia != null)
            {
                // o ficheiro foi fornecido
                // validar se o q foi fornecido é uma imagem ----> fazer em casa
                // formatar o tamanho da imagem

                // criar o caminho completo até ao sítio onde o ficheiro
                // será guardado
                path = Path.Combine(Server.MapPath("~/fotos/"), nomeImagem);

                // guardar o nome do ficheiro na BD
                //viaturas.Imagens = item(nomeImagem);
            }
            else
            {
                // não foi fornecido qq ficheiro
                // gerar uma mensagem de erro
                ModelState.AddModelError("", "Não foi fornecida uma imagem...");
                // devolver o controlo à View
                return View(viaturas);
            }
            //---------------------------


            if (ModelState.IsValid)
            {
                try
                {
                    db.Viaturas.Add(viaturas);
                    db.SaveChanges();
                    uploadFotografia.SaveAs(path);
                    return RedirectToAction("Index");
                }

                catch (Exception)
                {
                    ModelState.AddModelError("", "Houve um erro com a criação da viatura...");

                    /// se existir uma classe chamada 'Erro.cs'
                    /// iremos nela registar os dados do erro
                    /// - criar um objeto desta classe
                    /// - atribuir a esse objeto os dados do erro
                    ///   - nome do controller
                    ///   - nome do método
                    ///   - data + hora do erro
                    ///   - mensagem do erro (ex)
                    ///   - dados que se tentavam inserir
                    ///   - outros dados considerados relevante
                    /// - guardar o objeto na BD
                    /// 
                    /// - notificar um GESTOR do sistema, por email,
                    ///   ou por outro meio, da ocorrência do erro 
                    ///   e dos seus dados              

                }
            }

            ViewBag.ID = new SelectList(db.Compras, "ID", "NomeStand", viaturas.ID);
            return View(viaturas);
        }

        // GET: Viaturas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Viaturas viaturas = db.Viaturas.Find(id);
            if (viaturas == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.ID = new SelectList(db.Compras, "ID", "NomeStand", viaturas.ID);
            return View(viaturas);
        }

        // POST: Viaturas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Matricula,Marca,Modelo,Ano,TipoCombustivel,Cor,Cilindrada,Potencia,Lugares,Tipo,Imagens")] Viaturas viaturas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(viaturas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID = new SelectList(db.Compras, "ID", "NomeStand", viaturas.ID);
            return View(viaturas);
        }

        // GET: Viaturas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Viaturas viaturas = db.Viaturas.Find(id);
            if (viaturas == null)
            {
                return RedirectToAction("Index");
            }
            return View(viaturas);
        }

        // POST: Viaturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Viaturas viaturas = db.Viaturas.Find(id);
            try {               
            db.Viaturas.Remove(viaturas);
            db.SaveChanges();
            return RedirectToAction("Index");
            }
            catch(Exception)
            {
                ModelState.AddModelError("", string.Format("Não é possível apagar a viatura",
                                        id, viaturas.Marca)
           );
            }
            return View(viaturas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
