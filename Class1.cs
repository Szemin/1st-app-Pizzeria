using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
     struct Cena
        {
           public double small;
           public double medium;
           public double large;
        }
    public static void PrizeS()
        { 
        
           Cena pizza;

            pizza.small = 15;
            pizza.medium = 21.37;
            pizza.large = 35;

            start:
           Console.WriteLine($"Small - {pizza.small}" + "\n");
        
            Console.WriteLine($"Medium - {pizza.medium}" + "\n");
        
            Console.WriteLine($"Large - {pizza.large}" + "\n" );

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
                    Console.WriteLine($"Twoja pizza będzie kosztowała {pizza.large}");
                }
                    else if (size == "medium" || size == "Medium")
                {
                    Console.WriteLine($"Twoja pizza będzie kosztowała {pizza.medium}");
                }
                else if (size == "small" || size == "Small")
                {
                    Console.WriteLine($"Twoja pizza będzie kosztowała {pizza.small}");
                }
            }
            else
            {
                Console.WriteLine("wybrałeś niepoprawną opcję");
                goto start;
            }

        }
    }
}
