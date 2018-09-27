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
				new StreamReader($"../../{path}").ReadToEnd());
        }
		internal void getprintableStringAndActionDictionary(string line)
		{
			menu = "";
			menuActions = new Dictionary<char, Action>();
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
			menuActions.Add('0', () => Console.WriteLine("exit"));
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
					() => Console.WriteLine("\nBindings.run(textAndMenuID[1])"));//waiting for Bindings to be implemented
			}
		}

		public void Activate()
		{
			Console.Write(menu);
			Action action = getValidUserAction();
			//preform action
			action();
			Console.ReadKey();
		}

		private Action getValidUserAction()
		{
			Action action;
			char userChoice = Console.ReadKey().KeyChar;
			//Try to get action for the current user input otherwhise
			while (!menuActions.TryGetValue(userChoice, out action))
			{
				Console.WriteLine("Invalid menu action try again");
				userChoice = Console.ReadKey().KeyChar;
			}

			return action;
		}
	}
}
