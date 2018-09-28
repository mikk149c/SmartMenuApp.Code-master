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
        private string[] DanskArray;
        private string[] EnglishArray;
        private bool stillRunning = true;

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

            while (stillRunning)
            {
                switch (DanskEngleskValg.ToLower())
                {

                    case "1":
                        foreach (string value in DanskArray)
                            Console.WriteLine(value);
                            stillRunning = false;
                        break;
                    case "2":
                        foreach (string value in EnglishArray)
                            Console.WriteLine(value);
                            stillRunning = false;
                        break;
                    default:
                        Console.WriteLine("Undskyld, forstår ikke dit input /// I'm sorry, I don't understand that!");
                        break;
                }
            }

            while (stillRunning)
            {
                string MenuValg = Console.ReadLine();
                switch (MenuValg.ToLower())
                {
                    case "0":
                        Environment.Exit(0);
                        stillRunning = false;
                        break;
                    case "1":
                        Console.WriteLine("DoThis");
                        stillRunning = false;
                        break;
                    case "2":
                        Console.WriteLine("DoThat");
                        stillRunning = false;
                        break;
                    case "3":
                        Console.WriteLine("DoSomething");
                        stillRunning = false;
                        break;
                    case "4":
                        Console.WriteLine("42");
                        stillRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }


               
            
           

        }
    }
}
