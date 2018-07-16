using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Stand.Models
{
    public class Cliente
    {
        [Key]
        public int ID { get; set; }

        public string UserName { get; set; }

        public string Nome { get; set; }

        public string Fotografia { get; set; }

        public string Email { get; set; }

        public Boolean Vendedor { get; set; }

        public string NomeRegistoDoUtilizador { get; set; }

        // lista de compras

        public virtual ICollection<Compras> Compras { get; set; }
    }
}