using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto02.Models
{
    public class Usuario : EntityBase
    {
        [Required] //Login do funcionario
        public string Login { get; set; }

        [StringLength(20)]
        [MinLength(6)]
        [DataType(DataType.Password)] 
        [Required(ErrorMessage = "Necessario informar senha!")] //Senha do funcionario
        public string Senha { get; set; }

        public virtual IList<Funcionario> Funcionarios { get; set; }
        public virtual IList<Licenca> Licencas { get; set; }
    }
}