using FacadeDPClassLibrary;
namespace FacadeDPApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HotelReception hotelReception = new HotelReception();

            Console.WriteLine("**************Getting Indian Menu:**************");
            hotelReception.GetIndianMenu();

            Console.WriteLine("**************Getting Italian Menu:**************");
            hotelReception.GetItalianMenu();

            Console.WriteLine("**************Getting Chinese Menu:**************");
            hotelReception.GetChineseMenu();

            Console.ReadLine();
        }
    }
}