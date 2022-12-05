class Menu
{
    
    static void Main(string[] args)
    {
         Pizza();
    }

    static string[] Pizza()
    {
        string[] menu = { "1. margarita ", "2. hawajska ", "3. cappriciosa ", "4. dżalapino ", "5. ciasto z sosem " };
        foreach (string i in menu)
        {
            Console.WriteLine(i);
        }


        return menu;
    }


}