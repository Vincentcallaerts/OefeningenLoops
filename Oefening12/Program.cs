using System;


namespace Oefening12
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;
            Console.Write("Geef een getal in: ");
            getal = Convert.ToInt32(Console.ReadLine());
            string boom = "";
            for (int i = 1; i <= getal; i++)
            {
                boom += $"{i}";
                Console.WriteLine(boom);


            }
            Console.ReadLine();
        }
    }
}
