using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stand.Models
{
    public class Compras
    {
      

        [Key]
        [ForeignKey(nameof(Viatura))]
        public int ID { get; set; }

        public string NomeStand { get; set; }

        public string Preco { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Ano { get; set; }

        public string TipoCombustivel { get; set; }

        public string IdStand { get; set; }

        public Boolean Vendedor { get; set; }

        //Collections
        public virtual Viaturas Viatura { get; set; }
 
        public virtual Cliente Cliente { get; set; }

        //Chaves forasteiras

        [ForeignKey("Stand")]
        public int StandFK { get; set; }
        public virtual Stands Stand { get; set; }

    }
}