using System;


namespace Oefening16
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

                string temp = String.Empty;
                for (int k = 1; k <= getal - i; k++)
                {
                    temp += " ";
                }
                Console.Write(temp);
                temp = String.Empty;
                for (int j = 0; j < i; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("*" + " ");
                    Console.ResetColor();
                    
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
