﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_alexmazzotti2
{
    class LogicsFile
    {
        public List<Calciatore> Li { get; }
        public LogicsFile()
        {
            string filePath = "C:\\Users\\alexm\\OneDrive\\Desktop\\workspace-prog\\OOP_alexmazzotti2\\OOP_alexmazzotti2\\OOP_alexmazzotti2\\res\\listacalciatori.txt";
            const char separator = ';';
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parti = line.Split(separator);
                    Ruolo r;
                    switch (parti[1].ToCharArray()[0])
                    {
                        case ('P'):
                            r = Ruolo.P;
                            break;
                        case ('D'):
                            r = Ruolo.D;
                            break;
                        case ('C'):
                            r = Ruolo.C;
                            break;
                        default:
                            r = Ruolo.A;
                            break;
                    }
                    Li.Add(new Calciatore(parti[0].ToString(), r));
                }
            }
        }
    }
}
