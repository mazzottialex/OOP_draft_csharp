using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_alexmazzotti2
{
    class Modulo
    {
        public int _p { get; }
        public int _d { get; }
        public int _c { get; }
        public int _a { get; }
        public Modulo(int d, int c, int a)
        {
            _p = 1;
            _d = d;
            _c = c;
            _a = a;
        }

        public List<int> getList()
        {
            return new List<int>() { _p, _d, _c, _a };
        }
        override public string ToString()
        {
            return _d.ToString() +"-"+ _c.ToString() +"-"+ _a.ToString();
        }

    }
}
