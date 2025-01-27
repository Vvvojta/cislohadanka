using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int hadanecislo = 0;
        int nahodnecislo = random.Next(1, 101);

        while (hadanecislo != nahodnecislo)
        {
            Console.Write("Hádejte číslo: ");

            try
            {
                hadanecislo = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Zadejte platné celé číslo.");
                continue;
            }

            if (hadanecislo < nahodnecislo)
            {
                Console.WriteLine("Hledané číslo je větší.");
            }
            else if (hadanecislo > nahodnecislo)
            {
                Console.WriteLine("Hledané číslo je menší.");
            }
        }

        Console.WriteLine("Gratuluji, našel jsi číslo!");
        Console.ReadKey();
    }
}
