using System;


namespace Oefening3
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            bool running = true;

            do
            {

                Console.Write("Geef een input in: ");
                input = Console.ReadLine();
                if (input.ToLower() == "stop")
                {
                    running = false;
                    Console.WriteLine("De aplicatie stopt.");
                }


            } while (running);
            Console.ReadLine();
        }
    }
}
