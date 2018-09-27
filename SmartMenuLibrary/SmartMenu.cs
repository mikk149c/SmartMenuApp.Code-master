using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        public void LoadMenu(string path)
        {
         StreamReader file = new StreamReader(@"c:..\..\" + path + "");
           
            Console.ReadLine();

          
        }
        public void Activate()
        {
            // Implement ...
        }
    }
}
