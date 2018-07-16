using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stand.Models
{
    public class ViaturasStands
    {
        public ViaturasStands()
        {

        }

        [Key]
        public int ID { get; set; }

        public DateTime DataEntrega { get; set; }

        public DateTime? DataSaida { get; set; }

        public bool Vendido { get; set; }




        // fk para viatura
        [ForeignKey("Viatura")]
        public int ViaturaFK { get; set; }
        public virtual Viaturas Viatura { get; set; }

        // fk pra stand

        [ForeignKey("Stand")]
        public int StandFK { get; set; }
        public virtual Stands Stand { get; set; }
    }
}