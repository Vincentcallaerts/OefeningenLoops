using System;

namespace Oefening7
{
    class Program
    {
        static void Main(string[] args)
        {


            int getal,totaal;
            Console.Write("Geef een getal in: ");
            getal = Convert.ToInt32(Console.ReadLine());
            totaal = 0;


            for (int i = 1; i <= getal; i++)
            {
                
                Console.Write(i + " ");
                totaal += i;
            }
            Console.WriteLine($"\nTotaal: {totaal}");
            Console.ReadLine();


        }
    }
}
