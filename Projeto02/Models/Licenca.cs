﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto02.Models
{
    public class Licenca : EntityBase
    {
        [Required] //Chave do Software
        public string Chave { get; set; }
        [Required] //Quantidade de Software
        public int Quantidade { get; set; }
        [Required] //Software
        public Software Software { get; set; }
    }
}