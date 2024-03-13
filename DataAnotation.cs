﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RegularExpressions
{
    internal class DataAnotation
    {
        [Required]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Tittle {  get; set; }
        public float Fees { get; set; }
    }
}
