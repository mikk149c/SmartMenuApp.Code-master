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

            bool invalidInput = true;
            bool invalidInput2 = true;

            Console.WriteLine("Tryk 1 for Dansk, Press 2 for english");
            string DanskEngelskValg = Console.ReadLine();
            while (invalidInput)
            {
                switch (DanskEngelskValg)
                {
                    
                    case "1":
                        foreach (string value in DanskArray)
                            Console.WriteLine(value);
                        invalidInput = false;
                        break;
                    case "2":
                        foreach (string value in EnglishArray)
                            Console.WriteLine(value);
                        invalidInput = false;
                        break;
                    default:
                        Console.WriteLine("Undskyld, forstår ikke dit input /// I'm sorry, I don't understand that!");
                        DanskEngelskValg = Console.ReadLine();
                        break;
                }
            }

            string MenuValg = Console.ReadLine();
            while (invalidInput2)
            {
                switch (MenuValg)
                {
                    case "0":
                        Environment.Exit(0);
                        invalidInput2 = false;
                        break;
                    case "1":
                        Console.WriteLine("DoThis");
                        invalidInput2 = false;
                        break;
                    case "2":
                        Console.WriteLine("DoThat");
                        invalidInput2 = false;
                        break;
                    case "3":
                        Console.WriteLine("DoSomething");
                        invalidInput2 = false;
                        break;
                    case "4":
                        Console.WriteLine("42");
                        invalidInput2 = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        DanskEngelskValg = Console.ReadLine();
                        break;
                }
            }

            Console.ReadKey();
               
            
          
        }
    }
}
