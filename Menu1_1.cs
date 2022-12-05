class Menu
{  
    static void Main(string[] args)
    {
         Pizza();
        Console.WriteLine();
            Pov();
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

    static void dodajPizze()
    {
      
    }
}