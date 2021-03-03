using System;


namespace Oefening15
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal, teller;
            Console.Write("Geef een getal in: ");
            getal = Convert.ToInt32(Console.ReadLine());
            teller = 1;
            for (int i = 1; i <= getal; i++)
            {

                string temp = String.Empty;
                for (int k = 1; k <= getal-i; k++)
                {
                    temp += " ";
                }
                Console.Write(temp);
                temp = String.Empty;
                for (int j = 0; j < i; j++)
                {
                                       
                    Console.Write(teller + " ");
                    
                    teller++;
                }
                
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
