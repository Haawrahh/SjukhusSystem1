namespace SjukhusSystem
{

    public class Patient
    {
        public string Namn { get; set; } = string.Empty;  

        public string Personnummer { get; set; } = string.Empty;
        //Konstruktor för att skapa ett nytt patient direkt
                public Patient(string namn, string personnummer)
        {   Namn = namn;
            Personnummer = personnummer;
        }
    }
}
