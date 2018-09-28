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
         StreamReader Reader = new StreamReader(@"c:..\..\" + path + "");
           
         string smartmenutekst = Reader.ReadToEnd();

         string[] danskEngelsk = smartmenutekst.Split('/');
         


        }
        public void Activate()
        {
            // Implement ...
            Console.WriteLine("Tryk 1 for Dansk, Press 2 for english");
        }
    }
}
