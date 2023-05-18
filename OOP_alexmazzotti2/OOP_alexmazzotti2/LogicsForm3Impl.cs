using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_alexmazzotti2
{
    public enum Ruolo
    {
        P=1,
        D=2,
        C=3,
        A=4
    }
    class LogicsForm3Impl : ILogicsForm3
    {
        public List<Calciatore> Li { get; set; }
        public LogicsForm3Impl(List<Calciatore> li){
            this.Li=li;
        }
        public List<Calciatore> GetList(Modulo mod){
            List<int> val = mod.getList();
            List<Calciatore> liRet = new List<Calciatore>();
            foreach(int n in val)
            {
                
                liRet.Add=
            }
            return 

        }
    }
}
