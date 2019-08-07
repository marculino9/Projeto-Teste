using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto02.Models
{
    public class Funcionario : EntityBase
    {
        [Required] //Nome do funcionario
        public string Nome { get; set; }
        [Required] //Equipe
        public Equipe Equipe { get; set; }
        [Required] //Cargo
        public Cargo Cargo { get; set; }
        [Required] //Nome do computador do funcionario
        public string Maquina { get; set; }
        [Required]
        public Usuario Usuario { get; set; }
    }
}