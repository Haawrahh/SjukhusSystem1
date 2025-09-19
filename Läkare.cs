namespace SjukhusSystem
{
    //Läkare : har ett namn, en legitimation och en specialitet (t.ex. allmänläkare, kirurg)
    //En läkare kan skriver ut recept till patienter
    public class Lakare
    {
        public string Namn { get; set; }
        public string Legitimation { get; set; }
        public string Specialitet { get; set; }
        //konstruktor för att skapa ett nytt läkare objekt
        public Lakare(string namn, string legitimation, string specialitet)
        {
            Namn = namn;
            Legitimation = legitimation;
            Specialitet = specialitet;
        }
    }
}






