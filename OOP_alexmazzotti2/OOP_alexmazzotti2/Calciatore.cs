﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_alexmazzotti2
{
    class Calciatore
    {
        private string Nome { get; }
        private Ruolo Ruolo { get; }
        public Calciatore(string nome, Ruolo ruolo)
        {
            Nome = nome;
            Ruolo = Ruolo;
        }
        public override string ToString()
        {
            return Nome.ToString()+" "+Ruolo.ToString();
        }
    }
}
