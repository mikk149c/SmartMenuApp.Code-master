using System;
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

        string[] daEng;
        string[] danskArray;
        string[] englishArray;
        public void LoadMenu(string path)
        {
            StreamReader file = new StreamReader($"../../" + path + "");

            string smartMenu = file.ReadToEnd();
      
            daEng = smartMenu.Split('/');
            danskArray = daEng[0].Split('\n');
            englishArray = daEng[1].Split('\n');
        }
        
        public void Activate()
        {
            // Implement ...
            bool isValid;
            do {
                Console.WriteLine("Tryk 1 for Dansk\nPress 2 for english");
                ConsoleKeyInfo DanskEngleskValg = Console.ReadKey();
                Console.Clear();
                switch ((DanskEngleskValg.KeyChar).ToString())
                {
                    case "1":
                        foreach (string value in danskArray)
                            Console.WriteLine(value);
                        isValid = true;
                        break;
                    case "2":
                        foreach (string value in englishArray)
                            Console.WriteLine(value);
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine("Forkert input /// Wrong input\nTast enter for at prøve igen /// press enter to try again");
                        isValid = false;
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (isValid == false);
            
            ConsoleKeyInfo MenuValg = Console.ReadKey();
                Console.Clear();
            switch ((MenuValg.KeyChar).ToString())
            {
                case "1":
                    Functions.DoThis();
                    break;
                case "2":
                    
                    break;
                case "3":
                    //kode
                    break;
                case "4":
                    //kode
                    break;
                case "5":
                    //kode
                    break;
                case "default":
                    //kode
                    break;
            }


        }
    }
}