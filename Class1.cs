using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public static void PrizeS()
        { 
        
            double small = 15;
            double medium = 21.37;
            double large = 35;

            start:
            Console.WriteLine($"Small - {small}" + "\n");
        
            Console.WriteLine($"Medium - {medium}" + "\n");
        
            Console.WriteLine($"Large - {large}" + "\n" );

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
    
                Console.WriteLine($" \n To twój koszyk wybrałeś opcję {size,1} \n");
                if (size == "large" || size == "Large")
                {
                    Console.WriteLine($"Twoja pizza będzie kosztowała {large}");
                }
            }


        }
    }
}
