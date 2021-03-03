using System;


namespace Oefening8
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Console.Write("Hoeveel getallen wil je ingeven: ");
            int getal1 = Convert.ToInt32(Console.ReadLine());

            double totaal = 0;
            int getal2 = 0;

            for (int i = 1; i <= getal1; i++)
            {
                Console.Write($"Getal {i}: ");
                getal2 = Convert.ToInt32(Console.ReadLine());
                totaal += getal2;

            }
            Console.WriteLine();
            Console.WriteLine($"Gemiddelde: {Math.Round((totaal/getal1),2)}");
            Console.ReadLine();
        }
    }
}
