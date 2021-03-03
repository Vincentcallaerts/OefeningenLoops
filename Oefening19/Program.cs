using System;


namespace Oefening19
{
    class Program
    {
        static void Main(string[] args)
        {

            int delers;
            
            for (int i = 0; i <= 100; i++)
            {
                if (i == 0)
                {
                    Console.Write(0 + " ");
                }
                delers = 0;
                for (int j = 1; j <= 100; j++)
                {
                    if (i % j == 0)
                    {
                        delers++;
                    }
                }
                if (delers == 2)
                {
                    Console.Write(i + " ");
                }
            }

            Console.ReadLine();
        }        
    }
}
