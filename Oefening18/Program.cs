using System;


namespace Oefening18
{
    class Program
    {
        static void Main(string[] args)
        {

            string binair;
            for (int i = 0; i < 15; i++)
            {              
                binair = Convert.ToString(i, 2);
                Console.Write(binair + " ");
            }

            Console.ReadLine();
        }
    }
}
