using System;

namespace Oefening4
{
    class Program
    {
        static void Main(string[] args)
        {

            int getal;
            Console.Write("Geef een getal in: ");
            getal = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (getal % 2 == 0)
                {
                    getal += 5;
                    Console.WriteLine(getal);
                }
                else
                {
                    getal -= 3;
                    Console.WriteLine(getal);
                }
                

            } while (getal != 20);

            Console.ReadLine();
        }
    }
}
