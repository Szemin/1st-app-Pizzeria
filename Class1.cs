using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public static void PrizeS()
        { 
            start:
            Console.WriteLine("Small - 15zł" + "\n");
        
            Console.WriteLine("Medium - 21,37zł" + "\n");
        
            Console.WriteLine("Large - 35zł" + "\n" );

            Console.WriteLine("choose your pizza size" + "\n");
            string size = Console.ReadLine();
            Console.WriteLine(" \n");
            Console.WriteLine($"wybrałeś/aś opcję {size, 1} czy chcesz kontynuować? \n");
            Console.WriteLine("Tak - przejdź do koszyka / Nie - wybierz ponownie");

            var Uruchom = Console.ReadLine();
            if (Uruchom == "Nie" || Uruchom =="nie")
            {
                goto start;
            }
            else if (Uruchom == "Tak" || Uruchom == "tak")
            {



            }


        }
    }
}
