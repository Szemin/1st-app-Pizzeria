﻿using System.Security.Cryptography;
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
        Console.WriteLine("         1. Margarita");
        Console.WriteLine("         2. Hawajska");
        Console.WriteLine("         3. Cappriciosa");
        Console.WriteLine("         4. Dżalapino");
        Console.WriteLine("         5. Ciasto z sosem");
        Console.WriteLine("----------------------------");

    }

    static void Odswiez()
    {
        Console.Clear();
        Pizza();
        Console.WriteLine();
        Pov();
        Console.WriteLine("Choose info about pizza");
        choice();
        Console.WriteLine();
        action();
        Console.WriteLine();
        choice2();
        Console.ReadKey();
    }
    //press button to next action
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
        Console.WriteLine("              Ingredients              ");
        Console.WriteLine("              1.Ciasto ");
        Console.WriteLine("              2.Sos Pomidorowy ");
        Console.WriteLine("              3.Ser ");
        Console.WriteLine("-------------------------------------");
    }
    // ingredients of second pizza
    static void info2()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("              Ingredients              ");
        Console.WriteLine("              1.Ciasto ");
        Console.WriteLine("              2.Sos Pomidorowy ");
        Console.WriteLine("              3.Ser ");
        Console.WriteLine("              4.Szynka ");
        Console.WriteLine("              5.Ananas ");
        Console.WriteLine("-------------------------------------"); ;
    }
    //ingredients of third pizza
    static void info3()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("              Ingredients              ");
        Console.WriteLine("              1.Ciasto ");
        Console.WriteLine("              2.Sos Pomidorowy ");
        Console.WriteLine("              3.Ser ");
        Console.WriteLine("              4.Szynka ");
        Console.WriteLine("              5.Pieczarka ");
        Console.WriteLine("-------------------------------------"); ;
    }
    //ingredients of fourth pizza
    static void info4()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("              Ingredients             ");
        Console.WriteLine("              1.Ciasto ");
        Console.WriteLine("              2.Sos Pomidorowy ");
        Console.WriteLine("              3.Ser ");
        Console.WriteLine("              4.Szynka ");
        Console.WriteLine("              5.Dżalapino ");
        Console.WriteLine("-------------------------------------"); ;
    }
    //ingredients of fifth pizza
    static void info5()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("              Ingredients              ");
        Console.WriteLine("              1.Ciasto ");
        Console.WriteLine("           2.Sos Pomidorowy ");
        Console.WriteLine("-------------------------------------"); ;
    }

    //choosing action menu
    static void action()
    {
        Console.WriteLine("                            ");
        Console.WriteLine("----------------------------");
        Console.WriteLine("    Choose size of pizza    ");
        Console.WriteLine("----------------------------");
        Console.WriteLine(" Type : small, middle, large");
        Console.WriteLine("                            ");
    }

    //next action after choosing pizza
    static void choice2()
    {
         start: 
            string key = Console.ReadLine();
            switch (key)
            {
                case "small":
                    info1();
                    break;
                case "middle":
                    info2();
                    break;
                case "large":
                    info3();
                    break;
                case "back":
                    info4();
                    break;
                default:
                    Console.WriteLine("Wrong! ");
                    break;
            }
        Console.WriteLine("\n");
        Console.WriteLine("Czy uruchomić ponownie PROGRAM? Tak - t / Nie - n.");
        var Uruchom = Console.ReadLine();
        if (Uruchom == "t")
        {
            goto start;
        }
    }
}