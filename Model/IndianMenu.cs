using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDPClassLibrary.Model
{
    internal class IndianMenu : IMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Biriyani\nChappathi\nMeals");
        }
    }
}
