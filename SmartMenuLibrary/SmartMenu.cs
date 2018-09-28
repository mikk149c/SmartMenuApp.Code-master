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
            string menuChoice = Console.ReadLine();
            if (int.Parse(menuChoice) == 1)
            {
                Console.Clear();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(bothMenu[i]);
                }
            }
            else if (int.Parse(menuChoice) == 2)
            {
                Console.Clear();
                for (int i = 5; i < 10; i++)
                {
                    Console.WriteLine(bothMenu[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
