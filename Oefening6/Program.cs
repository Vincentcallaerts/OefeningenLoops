using System;

namespace Oefening6
{
    class Program
    {
        static void Main(string[] args)
        {

            int getal;
            Console.Write("Geef een getal in: ");
            getal = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(getal*i + " ");
            }
            Console.ReadLine();
        }
    }
}
