using Projeto02.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto02.Models
{
    public class Cargo : EntityBase
    {
        [Required]
        public ListaDeCargos ListaDeCargos { get; set; }

        public virtual IList<Funcionario> Funcionarios { get; set; }
    }
}