using System;

namespace Oefening2
{
    class Program
    {
        static void Main(string[] args)
        {

            int getal;
            Console.Write("Geef een getal in: ");
            getal = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                getal++;
                Console.WriteLine(getal);

            }
            Console.ReadLine();

        }
    }
}
