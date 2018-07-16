using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Stand.Models
{
    public class Imagens
    {
        public Imagens()
        {
            Viaturas = new HashSet<Viaturas>();
        }
        [Key]
        public int ID { get; set; }

        public string Fotografia { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string NumeroSeq { get; set; }

        public virtual ICollection<Viaturas> Viaturas { get; set; }

    }
}