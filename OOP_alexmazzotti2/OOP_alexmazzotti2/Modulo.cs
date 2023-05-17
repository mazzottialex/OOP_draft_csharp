using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_alexmazzotti2
{
    class Modulo
    {
        private int _p { get; }
        private int _d { get; }
        private int _c { get; }
        private int _a { get; }
        public Modulo(int d, int c, int a)
        {
            _p = 1;
            _d = d;
            _c = c;
            _a = a;
        }


        override public string ToString()
        {
            return _d.ToString() +"-"+ _c.ToString() +"-"+ _a.ToString();
        }

    }
}
