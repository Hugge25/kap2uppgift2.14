using System;
using System.Reflection.Metadata;
using System.Transactions;

namespace uppgfit_2._14
{
    class Porgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett decimal tal");
            double tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett till decimal tal");
            double tal2 = double.Parse(Console.ReadLine());

            double produkt = (tal1 * tal2);

            Console.WriteLine("Produkten av " + tal1 + " och " + tal2 + " är lika med "  + produkt);

        }
   
  
    }
}
