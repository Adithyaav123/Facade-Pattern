using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDPClassLibrary.Model
{
    internal class ItalianMenu : IMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Pizza\nPasta\nItalian Cheese");
        }
    }
}
