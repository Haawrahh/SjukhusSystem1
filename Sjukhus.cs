using System.Collections.Generic;
namespace SjukhusSystem
{
    //Sjukhus klassen : har ett namn och en location
    //Här smalas läkare,sjuksköterskor, patienter m.m 
    public class Sjukhus
    {
        public string Namn { get; set; } // Namnet på sjukhuset 
        public string Adress { get; set; } //Vart sjukhuset ligger
        
        //Relationer mellan klasser
        public List<Lakare> Lakarelista { get; } = new List<Lakare> ();  // Alla läkare som jobbar i sjukhus har det
        public List<Patient> Patientlista { get; } = new List<Patient> ();  //Alla patient som befinner sig i sjukhuset/avdelning

        //Kondtruktor för att skapa ett sjukhus 
        public Sjukhus(string namn, string adress)

        {

            Namn = namn;
            Adress = adress;

        }

        // Lägga till personal/patienter (enkla hjälpmetoder)
        public void LaggtillLakare(Lakare lakare)
        {
            Lakarelista.Add(lakare);
        }
        public void LaggtillPatient(Patient patient)
        {
            Patientlista.Add(patient);
        }





    }


}
