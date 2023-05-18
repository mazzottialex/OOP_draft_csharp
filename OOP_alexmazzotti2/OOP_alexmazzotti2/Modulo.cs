using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_alexmazzotti2
{
    class Modulo
    {
        public int P { get; }
        public int D { get; }
        public int C { get; }
        public int A { get; }
        public Modulo(int d, int c, int a)
        {
            P = 1;
            D = d;
            C = c;
            A = a;
        }

        public List<int> getList()
        {
            return new List<int>() { P, D, C, A };
        }
        override public string ToString()
        {
            return D.ToString() +"-"+ C.ToString() +"-"+ A.ToString();
        }

    }
}
