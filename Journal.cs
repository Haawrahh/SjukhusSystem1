using System.Collections.Generic;
namespace SjukhusSystem
{

    //Journal : tillhör en patient och inhåller infomation/journalpostar
    public class Journal
    {
        public Patient Patient { get; set; } //journalen handlar om en patient
        public List<JournalPost> Postar { get; set; } = new List<JournalPost>(); //alla anteckningar 

        //Konstruktor för att skapa en ny journal 
        public Journal(Patient patient)
        { Patient = patient; }

          

         //Lägg till en ny anteckning i journalen 
         public void LäggTillPost(JournalPost Post)
        {  
            Postar.Add(Post);
           
        }

    }

}
