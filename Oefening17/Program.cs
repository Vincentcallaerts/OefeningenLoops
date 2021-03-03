using System;


namespace Oefening17
{
    class Program
    {
        static void Main(string[] args)
        {


            int getal,totaal;
            Console.Write("Geef een getal in: ");
            getal = Convert.ToInt32(Console.ReadLine());
            totaal = 1;
            for (int i = 1; i <= getal; i++)
            {
                totaal = totaal * (getal-i+1);
            }
            Console.WriteLine(totaal);
            Console.ReadLine();
        }
    }
}
