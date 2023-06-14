using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_alexmazzotti2.src.logics
{
    class LogicsModuloImpl : ILogicsModulo
    {
        private List<Modulo> _listModuli = new List<Modulo> { 
                new Modulo(5, 3, 2),
                new Modulo(5, 2, 3),
                new Modulo(4, 5, 1),
                new Modulo(4, 4, 2),
                new Modulo(4, 3, 3),
                new Modulo(3, 5, 2),
                new Modulo(3, 4, 3),
            };
        public List<Modulo> GetLiModuli()
        {
            return _listModuli;
        }
    }
}
