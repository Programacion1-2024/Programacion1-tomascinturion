﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class GeneroLibro
    {
        public int IdGenereoLibro { get; set; }
        public Libro IdLibro { get; set; }
        public Genero IdGenero { get; set; }
    }
}
