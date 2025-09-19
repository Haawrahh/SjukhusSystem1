namespace SjukhusSystem
{
    //Medicin :har ett namn, en beskrivning och en styrka (t.ex. morfin 10mg)
    public class Medicin
    {
        public int MedicinID { get; set; }
        public string Namn { get; set; }
        public string Beskrivning { get; set; }
        public string Styrka { get; set; }
        // Relationer : en medicin kan finnas på flera recept

        public Medicin (int medicinID, string namn, string beskrivning, string styrka)
        {
            MedicinID = medicinID;
            Namn = namn;
            Beskrivning = beskrivning;
            Styrka = styrka;
        }

         public override string ToString() => $"{Namn} {Styrka} ({Beskrivning})";

    }

}







