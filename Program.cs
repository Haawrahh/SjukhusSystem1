using System;
namespace SjukhusSystem
{
    internal class SjukhusSystem
    {
        //Här påbörjar vi programmet
        static void Main(string[] args)
        {
            Console.WriteLine("Programmet startar utan fel");

            //Skapa ett sjukhus 
            Sjukhus sjukhus = new Sjukhus ("Sahlgrenska", "Göteborg");

            //Skapa personal (Läkare) - OBSERVERA: det saknas en " i slutet av Kirurg
            Lakare lakare1 = new Lakare("Hawo Raage", "L1234", "Kirurg");

            //Skapa en patient (namn,personnummer)
            Patient patient1 = new Patient("Ali Hassan", "19900101-1234");

            //Testutskrifter till konsolen
            Console.WriteLine("\n--- Läkare ---");
            Console.WriteLine($"Namn: {lakare1.Namn}, Specialitet: {lakare1.Specialitet}, Legitimation: {lakare1.Legitimation}");

            Console.WriteLine("\n--- Patient ---");
            Console.WriteLine($"Namn: {patient1.Namn}, Personnummer: {patient1.Personnummer}");

            //Vänta på att jag trycker på en tangent innan programmet stänger
            Console.ReadKey();// Vänta på att jag trycker på en tangent innan programmet stänger 

        }

    }



}

       