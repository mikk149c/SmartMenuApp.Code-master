using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        public void LoadMenu(string path)
        {
            // Implement ...
        }
        public void Activate()
        {
            // Implement ...
            int caseSwitch = 1;
            int caseSwitch = 2;
            int caseSwitch = 3;

            switch (caseSwitch)
            {

                case 1:
                    Console.WriteLine("Do This");
                    break;
                case 2:
                    Console.WriteLine("Do That");
                    break;
                case 3:
                    Console.WriteLine("Do Something");
                    break;
                default:
                    Console.WrtieLine("The value is unknown");
                    break;
            }
        }
    }
}
