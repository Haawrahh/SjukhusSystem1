namespace SjukhusSystem
{
    //Sjuksköterska : har ett namn, en anställningsdatum och en personalID
    //En sjuksköterska kan administrera medicin till patienter
    public class Sjukskoterska
    {
        public string Namn { get; set; }
        public string Legitimation { get; set; }
        public string Avdelning { get; set; }

        //konstruktor för att skapa ett nytt sjuksköterska objekt
        public Sjukskoterska(string namn, string legitimation, string avdelning)
        {
            Namn = namn;
            Legitimation = legitimation;
            Avdelning = avdelning;
        }
        //Enkel metod : mäter patienterna blodtryck
        //Det sparas i journalen
                public string MatarBlodtryck(Patient patient, string blodtryck)
        {
            return $"Sjuksköterska {Namn} mätte blodtryck på {patient.Namn}: {blodtryck}";

        }
        

    }

}