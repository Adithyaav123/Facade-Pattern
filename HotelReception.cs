using FacadeDPClassLibrary.Model;

namespace FacadeDPClassLibrary
{
    public class HotelReception
    {
      
            public void GetIndianMenu()
            {
                IHotel indHotel = new IndianHotel();
                IMenu menu = indHotel.GetMenu();
                menu.DisplayMenu();
            }
            public void GetItalianMenu()
            {
                IHotel italianHotel = new ItalianHotel();
                IMenu menu = italianHotel.GetMenu();
                menu.DisplayMenu();
            }
            public void GetChineseMenu()
            {
                IHotel chineseHotel = new ChineseHotel();
                IMenu menu = chineseHotel.GetMenu();
                menu.DisplayMenu();
            }
        }
    }
