using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        string[] bothMenu;
        string[] danskMenu;
        string[] englishMenu;
        public void LoadMenu(string path)
        {
            System.IO.StreamReader file =
    new System.IO.StreamReader($"../../" + path + "");
            bothMenu = file.ReadToEnd().Split('\n');
        }
        public void Activate()
        {
            Console.WriteLine("Vælg dit sprog // Choose your language!\n1. Dansk\n2. English");
            ConsoleKeyInfo menuChoice = Console.ReadKey();
            if (menuChoice.KeyChar == '1')
            {
                Console.Clear();
                for (int i = 0; i < 6; i++)
                {
                    danskMenu[i] = bothMenu[i];
                }
            }
            else if (menuChoice.KeyChar == '2')
            {
                Console.Clear();
                for (int i = 7; i < 12; i++)
                {
                    englishMenu[i] = bothMenu[i];
                }
            }

            switch (menuChoice.ToString())
            {
                case "1":
                    foreach (string value in danskMenu)
                        Console.WriteLine(value);
                    break;
                case "2":
                    foreach (string value in englishMenu)
                        Console.WriteLine(value);
                    break;
                default:
                    Console.WriteLine("Undskyld, forstår ikke dit input /// I'm sorry, I don't understand that!");
                    break;
            }


            Console.ReadLine();
        }
    }
}
