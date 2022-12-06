using System.Security.Cryptography;
using System;
class Menu
{  
    static void Main(string[] args)
    {
        Odswiez();
    }

    static string[] Pizza()
    {
        Console.WriteLine(" Pizza: lista ");
        string[] menu = { "1. margarita ", "2. hawajska ", "3. cappriciosa ", "4. dżalapino ", "5. ciasto z sosem " };
        foreach (string i in menu)
        {
            Console.WriteLine(i);
        }

        return menu;
    }

    static void Pov()
    {
        Console.WriteLine("  ^    -----MENU-----    ^  ");
        Console.WriteLine("----------------------------");
        Console.WriteLine("         1. Info");
        Console.WriteLine("         2. Info");
        Console.WriteLine("         3. Info");
        Console.WriteLine("         4. Info");
        Console.WriteLine("         5. Info");
        Console.WriteLine("----------------------------");

    }

    static void Odswiez()
    {
        Console.Clear();
        Pizza();
        Console.WriteLine();
        Pov();
        choice();
        Console.ReadKey();
    }

    static void choice()
    {
        int key;
        int.TryParse(Console.ReadLine(), out key);
        switch (key)
        {
            case 1:
                info1();
                break;  
            case 2:
                info2();
                break;
            case 3:
                info3();
                break;
            case 4:
                info4();
                break;
            case 5:
                info5();
            break;
                default:
                Console.WriteLine("you choose wrong option i can't execute it");
                break;
        }
    }


    //ingredients of first pizza
    static void info1()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("              Składniki              ");
        Console.WriteLine("              1.Ciasto ");
        Console.WriteLine("           2.Sos Pomidorowy ");
        Console.WriteLine("               3.Ser ");
        Console.WriteLine("-------------------------------------");
    }
   // ingredients of second pizza
    static void info2()
    {
        Console.WriteLine("składniki: ");
    }
    //ingredients of third pizza
    static void info3()
    {
        Console.WriteLine("składniki: ");
    }
    //ingredients of fourth pizza
    static void info4()
    {
        Console.WriteLine("składniki: ");
    }
    //ingredients of fifth pizza
    static void info5()
    {
        Console.WriteLine("składniki: ");
    }
}