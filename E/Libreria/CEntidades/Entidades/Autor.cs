﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Autor 
    {
        public int IdAutor { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Biografia { get; set; }
        public string Nacionalidad { get; set; }
        public Persona PersonaAutor { get; set; }
    }
}
