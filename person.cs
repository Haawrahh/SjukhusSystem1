namespace SjukhusSystem
{
    //Person : basklass som har namn och personnummer
    public class Person
    {
               public string Namn { get; set; } = string.Empty;  // fullständig namn som t.ex. ¨ Hawo Raage¨
        public string Personnummer { get; set; } = string.Empty;  //Personnummer i formatet ÅÅÅÅMMDDXXXX
        // Konstruktor för att skapa ett nytt person objekt
        public Person(string namn, string personnummer)
        {
            Namn = namn;
            Personnummer = personnummer;
        }
    }

}