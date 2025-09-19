namespace SjukhusSystem
{
    //journalPost = en anteckning som en läkare eller sjuksköterska gör om en patient
    public class JournalPost
    {
        public DateTime Datum { get; } // datum när journalposten skapades
        public string Anteckning { get; set; } // själva anteckningen
        public Patient Patient { get; } // patienten som journalposten handlar om
        public Lakare Lakare { get; } // läkaren som gjorde anteckningen

        // konstruktor för att skapa en ny journalpost
        public JournalPost(DateTime datum, string anteckning, Patient patient, Lakare lakare)
        {
            Datum = datum;
            Anteckning = anteckning;
            Patient = patient;
            Lakare = lakare;
        }
    }
}