using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stand.Models
{
    public class Stands
    {
        public Stands()
        {
            this.Compras = new HashSet<Compras>();
            this.Viaturas = new HashSet<ViaturasStands>();
        }

        [Key]
        public int ID { get; set; }

     /*   [Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")]
        [RegularExpression("[A-ZÍÉÂÁ][a-záéíóúàèìòùâêîôûäëïöüãõç]+(( |'|-| dos | da | de | e | d')[A-ZÍÉÂÁ][a-záéíóúàèìòùâêîôûäëïöüãõç]+){1,3}",
           ErrorMessage = "O {0} apenas pode conter letras e espaços em branco. Cada palavra começa em Maiúscula, seguida de minúsculas...")]*/
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string CodigoPostal { get; set; }

        public string Email { get; set; }

        public string Localizacao { get; set; }

        public string Zona { get; set; }




        //muitos para muitos
        public virtual ICollection<Compras> Compras { get; set; }

        public virtual ICollection<ViaturasStands> Viaturas { get; set; }



    }
}