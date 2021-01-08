﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
    public class Categoria
    {
        public int Id{ get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

    }
}
