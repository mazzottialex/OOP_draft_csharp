using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_alexmazzotti2
{
    class LogicsFile
    {
        public LogicsFile()
        {
            string url = "listacalciatori.txt";
            char separator = ';';
            List<String> li = new List<string>();
            using (StreamReader reader = new StreamReader(url))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parti=line.Split();
                    parti[0];
                    parti[1];
                }
            }
        }
    }
}
