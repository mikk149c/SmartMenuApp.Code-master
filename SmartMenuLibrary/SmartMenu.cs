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
         string[] DanskArray = danskEngelsk[0].Split('\n');
         string[] EnglishArray = danskEngelsk[1].Split('\n');

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
    }
}
