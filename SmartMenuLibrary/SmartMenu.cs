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
		private Dictionary<char, string> menuActions;
		private string menu;

        public void LoadMenu(string path)
        {
			getprintableStringAndActionDictionary(
				new StreamReader($"../../{path}").ReadToEnd());
        }
		internal void getprintableStringAndActionDictionary(string line)
		{
			menu = "";
			menuActions = new Dictionary<char, string>();
			//Create an array of the lines from the menu string
			string[] menuLineArray = line.Split('\n');
			getSmartMenuDescriptionAndExitAction(menuLineArray);
			getMenuPointTextAndActions(menuLineArray);
		}

		private void getSmartMenuDescriptionAndExitAction(string[] menuLineArray)
		{
			//Add the first two lines to menu string
			menu =
				$"{menuLineArray[0]}\n" +
				$"{menuLineArray[1]}\n";
			//Add the exit action to menuActions
			menuActions.Add('0', "exit");
		}

		private void getMenuPointTextAndActions(string[] menuLineArray)
		{
			for (int i = 2; i < menuLineArray.Length; i++)
			{
				//Split the current line into menu point text and ID
				string[] textAndMenuID = menuLineArray[i].Split(';');
				menu += $"{textAndMenuID[0]}\n";
				//Add action to menuActions
				menuActions.Add(
					Convert.ToChar(textAndMenuID[0].Split(' ')[1]),
					textAndMenuID[1]);
			}
		}

		public void Activate()
		{
			Console.Write(menu);
			string menuID = getValidMenuIDFromUser();
			Console.WriteLine('\n' + menuID);
			Console.ReadKey();
		}

		private string getValidMenuIDFromUser ()
		{
			string menuID;
			char userChoice = Console.ReadKey().KeyChar;
			//As long as the user fails to enter a key wich is in the dictionary try again
			while (!menuActions.TryGetValue(userChoice, out menuID))
			{
				Console.WriteLine("\n321321Invalid menu action try again");
				userChoice = Console.ReadKey().KeyChar;
			}

			return menuID;
		}
	}
}
