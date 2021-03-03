using System;


namespace Oefening9
{
    class Program
    {
        static void Main(string[] args)
        {

            int getal;
            Console.Write("Geef een getal in: ");
            getal = Convert.ToInt32(Console.ReadLine());
     


            for (int i = 1; i <= getal; i++)
            {

                Console.WriteLine($"Het kwadraat van {i} is {Math.Pow(i,2)} ");
                
            }
           
            Console.ReadLine();

        }
    }
}
