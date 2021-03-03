using System;

namespace Oefening11
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;
            Console.Write("Geef een getal in: ");
            getal = Convert.ToInt32(Console.ReadLine());
            string boom = "";
            for (int i = 0; i < getal; i++)
            {
                boom += "*";
                Console.WriteLine(boom);
               

            }
            Console.ReadLine();
        }
    }
}
