using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stand.Models
{
    public class Viaturas
    {
        public Viaturas()
        {
            this.Stands = new HashSet<ViaturasStands>();
        }

        [Key]
        //dados especificos da viatura
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; } // chave primaria 

        

        public string Matricula { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Ano { get; set; }

        public string TipoCombustivel { get; set; }

        public string Cor { get; set; }

        public string Cilindrada { get; set; }

        public string Potencia { get; set; }

        public string Lugares { get; set; }

        public string Tipo { get; set; }

       // public string Fotografia { get; set; }



        public virtual ICollection<ViaturasStands> Stands { get; set; }

       
        public virtual ICollection< Imagens> Imagens { get; set; }

        public virtual Compras  Compra { get; set; }

    }
}