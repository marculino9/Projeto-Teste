using Projeto02.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projeto02.Models
{
    public class Equipe : EntityBase
    {
        //equipe tem funcionario (gestor)
        public Gestor Gestor { get; set; }
        [Required]
        public ListaDeEquipes ListaDeEquipes { get; set; }

        public virtual IList<Funcionario> Funcionarios { get; set; }
    }
}