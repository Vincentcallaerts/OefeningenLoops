using System;


namespace OefeningenLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            int getal;
            Console.Write("Geef een getal in: ");
            getal = Convert.ToInt32(Console.ReadLine());

            for (int i = getal; i < 20; i++)
            {
                Console.WriteLine(i+1);
            }
            Console.ReadLine();
        }
    }
}
