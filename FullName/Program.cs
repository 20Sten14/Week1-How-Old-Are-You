using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1... Programm küsib kasutaha käest kasutaja eesnime
            //Step 2... Programm küsib kasutaja käest kasutaja perekonnanime
            //Step 3... Programm tervitab kasutajat kasutades neid anemeid

            Console.WriteLine("What is your first name?");
            String Username = Console.ReadLine();
            Console.WriteLine("Hello, " + Username + " but what is ur surname");
            String Username1 = Console.ReadLine();
            Console.WriteLine($"Thank you { Username} {Username1} ");
            Console.WriteLine($"bye bye!");

            // Step 1-3 Completed

            Console.Read();
        }
    }
   
}
