using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_alexmazzotti2
{
    class Calciatore
    {
        public string _nome { get; }
        public char _pos { get; }
        public Calciatore(string nome, char pos)
        {
            _nome = nome;
            _pos = pos;
        }
        public override string ToString()
        {
            return _nome.ToString()+" "+_pos.ToString();
        }
    }
}
