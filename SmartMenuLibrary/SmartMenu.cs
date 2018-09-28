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
			string menuSpec = new StreamReader($"../../{path}").ReadToEnd();
			generateMenugAndActionDictionary(getLanguage(menuSpec));
        }

		private string getLanguage(string menuSpec)
		{
			Console.Clear();
			generateLanguageMenuPointsAndActions(menuSpec);
			Console.WriteLine("Chose language/ Vælg sprog");
			Console.Write(menu);
			string selectedLanguage = getValidMenuIDFromUser();
			Console.Clear();
			return selectedLanguage;
		}

		private void generateLanguageMenuPointsAndActions(string menuSpec)
		{
			menuActions = new Dictionary<char, string>();
			string[] languages = menuSpec.Split('|');
			for (int i = 0; i < languages.Length; i++)
			{
				string[] keyAndLanguages = languages[i].Split('§');
				menu += $"{i}: {keyAndLanguages[0].Trim()}\n";
				menuActions.Add(i.ToString()[0], keyAndLanguages[1].Trim());
			}
		}

		internal void generateMenugAndActionDictionary(string line)
		{
			menu = "";
			menuActions = new Dictionary<char, string>();
			//Create an array of the lines from the menu string
			string[] menuLineArray = line.Split('\n');
			generateMenuDescriptionAndExitAction(menuLineArray);
			generateMenuPointsAndActions(menuLineArray);
		}

		private void generateMenuDescriptionAndExitAction(string[] menuLineArray)
		{
			//Add the first two lines to menu string
			menu =
				$"{menuLineArray[0]}\n" +
				$"{menuLineArray[1]}\n";
			//Add the exit action to menuActions
			menuActions.Add('0', "exit");
		}

		private void generateMenuPointsAndActions(string[] menuLineArray)
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
				Console.WriteLine("\nInvalid menu action try again");
				userChoice = Console.ReadKey().KeyChar;
			}

			return menuID;
		}
	}
}