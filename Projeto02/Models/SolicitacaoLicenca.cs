using Projeto02.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto02.Models
{
    public class SolicitacaoLicenca : EntityBase
    {
        [Required] //Nome da licenca
        public string Nome { get; set; }
        [Required] //Data de inicial para usar a licenca
        public DateTime DataInicio { get; set; }
        [Required] //Data Final para usar a licenca
        public DateTime DataTermino { get; set; }
        [Required] //Fazer Numero
        public int Protocolo { get; set; } //NAO PRECISA MAS E BOM
        public Usuario Usuario { get; set; }
        //Motivo de uso
        public string MotivoDeUso { get; set; }
        [Required]
        public ListaDeStatus ListaDeStatus { get; set; }
        [Required]
        public ListaDeRequerimento ListaDeRequerimento { get; set; }
    }
}
