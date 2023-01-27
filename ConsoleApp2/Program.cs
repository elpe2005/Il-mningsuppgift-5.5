using System;

namespace uppgift54
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] svar = new string[] { "Det är Berlin", "Det är inte en elefant", "Det husdjuret är en giraff", "Grönt", "rött", "sju stycken", "stockholm", "nej", "ja", "Abdi" };
            Random random = new Random();
            int index = random.Next(svar.Length);
            Console.WriteLine("Skriv en fråga");
            Console.ReadLine();
            Console.WriteLine($"svar: {svar[index]}");
        }
    }
}