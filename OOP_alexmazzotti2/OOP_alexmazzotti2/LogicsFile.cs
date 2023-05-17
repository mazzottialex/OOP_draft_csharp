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
        public LogicsFile()
        {
            string filePath = "C:\\Users\\alexm\\OneDrive\\Desktop\\workspace-prog\\OOP_alexmazzotti2\\OOP_alexmazzotti2\\OOP_alexmazzotti2\\res\\listacalciatori.txt";
            const char separator = ';';
            List<Calciatore> li = new List<Calciatore>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    string[] parti=line.Split(separator);
                    li.Add(new Calciatore(parti[0].ToString(), parti[1].ToCharArray()[0]));
                    //Console.WriteLine(parti[1].ToCharArray()[0]);
                }
            }

            Console.WriteLine(li.Take(1).ToString());
        }
    }
}