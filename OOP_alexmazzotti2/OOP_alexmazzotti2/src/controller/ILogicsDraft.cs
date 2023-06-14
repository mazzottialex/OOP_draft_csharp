using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_alexmazzotti2
{
    interface ILogicsDraft
    {
        List<Calciatore> GetList(Modulo mod);
        void AddCalciatore(Calciatore c);
        bool isCompleted(); 
    }
}
