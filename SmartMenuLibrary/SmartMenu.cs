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
		private string menu;
        public void LoadMenu(string path)
        {
			menu = new StreamReader($"../../{path}").ReadToEnd();
        }
        public void Activate()
        {
			string print = "";
			string[] menuLineArray = menu.Split('\n');
			print = 
				$"{menuLineArray[0]}\n" +
				$"{menuLineArray[1]}\n";

			for (int i = 2; i < menuLineArray.Length; i++)
			{
				string[] textAndMenuID = menuLineArray[i].Split(';');
				print += $"{textAndMenuID[0]}\n";
				//binding.run(textAndMenuID[1]);
			}
			Console.Write(print);
        }
    }
}
