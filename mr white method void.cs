 string name;
 Console.WriteLine("say my name");
 name = Console.ReadLine();

for (int i = 1; i <= 5; i++)
{
    SayHi(name);
}
 Console.WriteLine();

static void SayHi(string name)
{
    Console.WriteLine("hello " + name);
    Console.WriteLine("ye you god damn right");
}