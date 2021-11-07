using System;

namespace CirkelBerekenen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
            //double pi = Math.PI;
            //Oppervlakte cirkel = π x straal^2

            double straal = Convert.ToInt32(Console.ReadLine());
            double ResultA = Math.Pow(straal, 2);


            double pi = Math.PI * ResultA;

            Console.WriteLine(pi);
            */

            /*
            // lengte x breedten x hoogten in dm

            Console.WriteLine("vul de lengte van de contaner in in dm");
            double lengte = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("vul de breedten van de contaner in in dm");
            double breedten = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("vul de hoogte van de contaner in in dm");
            double hoogte = Convert.ToInt32(Console.ReadLine());

            double inhoud = lengte * breedten * hoogte;

            Console.WriteLine("de inhoud van de contaner in liters is: " + inhoud);


            double seventig = (inhoud / 100) * 70;
            Console.WriteLine("70% van de contaner in liters is: " + seventig + "L");

            */

            // inhoud cilinder = π * r2 * h 

            Console.WriteLine("vul de radius van de cilinder in");
            double radius = Convert.ToInt32(Console.ReadLine());
            double Result = Math.Pow(radius, 2);


            Console.WriteLine("vul de hoogte van de radius");
            double hoogte = Convert.ToInt32(Console.ReadLine());

            double inhoud = Math.PI * Result * hoogte;

            Console.WriteLine("hoeveel prosent wil je de cilinder gevuld?");
            double prosent = Convert.ToInt32(Console.ReadLine());

            double seventig = (inhoud / 100) * prosent;
            Console.WriteLine(prosent + "% van de cilinder is: " + seventig);



        }
    }
}
