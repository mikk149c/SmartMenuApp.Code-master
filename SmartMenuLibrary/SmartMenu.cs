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
		private Dictionary<char, Action> menuActions;
		private string menu;

        public void LoadMenu(string path)
        {
			getprintableStringAndActionDictionary(
				new StreamReader($"../../{path}").ReadToEnd(),
				out menu,
				out menuActions);
        }
        public void Activate()
        {
			Console.Write(menu);										//Print menu

			char userChoice = Console.ReadKey().KeyChar;				//Gets user choice
			Action action;												//Creates and empty action
			while (!menuActions.TryGetValue(userChoice, out action))	//Try to get action for the current user input otherwhise
			{
				Console.WriteLine("Invalid menu action try again");
				userChoice = Console.ReadKey().KeyChar;						//Get a new user input
			}
			action();                                                   //preform action
			Console.ReadKey();
        }

		internal void getprintableStringAndActionDictionary(
			string line,
			out string print,
			out Dictionary<char, Action> menuActions)
		{

			print = "";													//Initialize print
			menuActions = new Dictionary<char, Action>();				//Initialize menuActions
			string[] menuLineArray = line.Split('\n');                  //Create an array of the lines from the mu string
			print =														//Add the first two lines to print
				$"{menuLineArray[0]}\n" +
				$"{menuLineArray[1]}\n";

			menuActions.Add('0', () => Console.WriteLine("exit"));		//Add the exit action to menuAvtions

			for (int i = 2; i < menuLineArray.Length; i++)              //for each line after the first two
			{
				string[] textAndMenuID = menuLineArray[i].Split(';');       //Split the current line into menu point text and ID
				print += $"{textAndMenuID[0]}\n";                           //Adds menu point text to print string
				menuActions.Add(											//Add action to menuActions
					Convert.ToChar(textAndMenuID[0].Split(' ')[1]),
					() => Console.WriteLine("\nBindings.run(textAndMenuID[1])"));//waiting for Bindings to be implemented
			}
		}
    }
}
