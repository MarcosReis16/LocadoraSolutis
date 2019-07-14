﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraSolutis.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string CPFCliente { get; set; }

        public decimal ValorDivida { get; set; }



    }
}
