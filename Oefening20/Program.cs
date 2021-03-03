using System;

namespace Oefening20
{
    class Program
    {
        static void Main(string[] args)
        {

            int delers1,delers2,priemgetal1,priemgetal2;
            Console.Write("Input: ");
            int input = Convert.ToInt32(Console.ReadLine());
            priemgetal1 = 0;
            priemgetal2 = 0;

            for (int i = 0; i <= input; i++)
            {
                if (i != 0 || i != 1)
                {
                    delers1 = 0;
                    for (int j = 1; j <= input; j++)
                    {
                        if (i % j == 0)
                        {
                            delers1++;
                        }
                    }
                    if (delers1 == 2)
                    {
                        //het is een priemgetal 
                        priemgetal1 = i;
                        for (int k = 0; k < input; k++)
                        {
                            delers2 = 0; 
                            for (int l = 1; l <= input; l++)
                            {
                                if (k % l == 0)
                                {
                                    delers2++;
                                }
                            }
                            if (delers2 == 2)
                            {
                                //het is een priemgetal 
                                priemgetal2 = k;
                                if (priemgetal1 + priemgetal2 == input)
                                {
                                    Console.WriteLine($"{priemgetal1} + {priemgetal2} = {priemgetal1 + priemgetal2}");
                                }

                            }
                        }                    
                    }
                }                
            }
                Console.ReadLine();
        }
    }

}
