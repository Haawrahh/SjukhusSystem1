namespace SjukhusSystem
{
    //Personal : abstrakt basklass för sjukhus personal,  kan vara läkare, städerska, vaktmästare eller sjuksköterska
    public class Personal
    {
        public int PersonalID { get; set; } // unikt ID för varje personal
        public string Namn { get; set; } // personalens namn
        public string Roll { get; set; } // Roll : t.ex. "Läkare" eller "Sjuksköterska"
        public string Avdelning { get; set; } // t.ex. Avdelning intensivvård, kirurgi
        // Konstruktor för att skapa en ny personal
        public Personal(int personalID, string namn, string roll, string avdelning)
        {
            PersonalID = personalID;
            Namn = namn;
            Roll = roll;
            Avdelning = avdelning;
        }
        // Enkel metod : returnerar en sträng med personalens information
         public override string ToString()
        { 
            return $"{Namn} ({Roll}) - Avdelning: {Avdelning}";
        }
        
        
    }

}