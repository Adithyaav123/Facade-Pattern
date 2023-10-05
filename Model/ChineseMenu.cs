using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDPClassLibrary.Model
{
    internal class ChineseMenu : IMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Chinese Hot Pot\nSpring Rolls\nWonton Soup");
        }
    }
}
