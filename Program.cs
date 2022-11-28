namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("podaj numer");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("podaj numer2");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        
    }
}