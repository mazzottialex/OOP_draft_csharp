using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_alexmazzotti2
{
    public class Calciatore
    {
        public string Nome { get; }
        public Ruolo Ruolo { get; }
        public Calciatore(string nome, Ruolo ruolo)
        {
            Nome = nome;
            Ruolo = ruolo;
        }
        public override string ToString()
        {
            return Nome.ToString()+" "+Ruolo.ToString();
        }
    }
}
