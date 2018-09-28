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
                    Console.WriteLine(bothMenu[i]);
                }
            }
            else if (menuChoice.KeyChar == '2')
            {
                Console.Clear();
                for (int i = 7; i < 12; i++)
                {
                    Console.WriteLine(bothMenu[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
