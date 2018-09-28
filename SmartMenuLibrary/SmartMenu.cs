﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FunctionLibrary;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        private string[] DanskArray;
        private string[] EnglishArray;
        
        public void LoadMenu(string path)
        {
         StreamReader Reader = new StreamReader(@"c:..\..\" + path + "");
           
         string smartmenutekst = Reader.ReadToEnd();

            string[] DanskEngelsk = smartmenutekst.Split('/');
            DanskArray = DanskEngelsk[0].Trim().Split('\n');
            EnglishArray = DanskEngelsk[1].Trim().Split('\n');
        }

       
        public void Activate()
        {
            // Implement ...

            Console.WriteLine("Tryk 1 for Dansk, Press 2 for english");
            string DanskEngleskValg = Console.ReadLine();
            switch (DanskEngleskValg.ToLower())
            {

                case "1":
                    foreach (string value in DanskArray)
                        Console.WriteLine(value);
                    break;
                case "2":
                    foreach (string value in EnglishArray)
                        Console.WriteLine(value);
                    break;
                default:
                    Console.WriteLine("Undskyld, forstår ikke dit input /// I'm sorry, I don't understand that!");
                    break;
            }
            string MenuValg = Console.ReadLine();
            switch (MenuValg.ToLower())
            {
                case "0":
                    //kode
                    break;
                case "1":
                    //kode
                    break;
                case "2":
                    //kode
                    break;
                case "3":
                    //kode
                    break;
                case "4":
                    //kode
                    break;
                case "default":
                    //kode
                    break;
            }
        }
    }
}
