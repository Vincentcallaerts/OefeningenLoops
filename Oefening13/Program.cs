using System;


namespace Oefening13
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

                for (int j = 0; j < i; j++)
                {
                    boom += $"{i}";
                }
                Console.WriteLine(boom);
                boom = "";

            }
            Console.ReadLine();
        }
    }
}
