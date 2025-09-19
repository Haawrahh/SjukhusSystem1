namespace SjukhusSystem
{
    //Recept : blir utskriven av en läkare och det är medicin till en patient
    public class Recept
    {
        
        public int ReceptId { get; set; }
        public DateTime UtfardatDatum { get; }

        //Relationer mellan klasser 
        public Lakare Lakare { get; }  // en läkare kan skriva ut flera recept
        public Patient Patient { get; } // en patient får recept från läkaren
        public Medicin Medicin { get; } //medicin finns oftast på receot 
        public string Dosering { get; set; } // hur mycket medicin patienten ska ta

        //Konstruktor 

        public Recept(int receptId, DateTime utfardatDatum,Lakare lakare, Patient patient, Medicin medicin, string dosering)

        {
            ReceptId = receptId;
            UtfardatDatum = utfardatDatum;
            Lakare = lakare;
            Patient = patient;
            Medicin = medicin;
            Dosering = dosering;
    

        }

    }

}

