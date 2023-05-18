using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_alexmazzotti2
{
    class LogicsForm3Impl : ILogicsForm3
    {
        public List<Calciatore> Li { get; set; }
        public LogicsForm3Impl(){
            LogicsFile file = new LogicsFile();
            Li = file.GetLi();
        }
        public List<Calciatore> GetList(Modulo mod){
            List<int> val = mod.GetList();
            List<Calciatore> liRet = new List<Calciatore>();
            int i = 0;
            //val lista 1,4,3,3
            //n assume 1   4   3   3
            //i 0 1 2 3
            foreach(int n in val)
            {
                Ruolo ruolo = (Ruolo)Enum.Parse(typeof(Ruolo), i.ToString());
                liRet.AddRange(GetRandomPlayers(ruolo, n));
                i++;
            }
            return liRet;

        }

        private List<Calciatore> GetRandomPlayers(Ruolo r, int n)
        {
            List<Calciatore> newLi = new List<Calciatore>();
            Random rnd = new Random();
            int val;
            for (int i = 0; i < n; i++){
                do{
                    val = rnd.Next(Li.Count());
                } while (!newLi.Contains(Li[val]) && r==Li[val].Ruolo);
                newLi.Add(Li[val]);
            }
            return newLi;
        }
    }
}
