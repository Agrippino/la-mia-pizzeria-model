using PizzeriaAgrippino.Models;
namespace PizzeriaAgrippino.Utilies
{
    public static class PostData 
    {
        //è una classe statica perché deve solo restituirci i post e nient'altro 

        private static List<Pizze> pizzes;

        //creiamo un metodo prende la mia lista di post e la restituisce
        //essendo una classe statica per far dunzonare tutto dobbiamo inserire PostData.Pizzes, altrimenti non funziona 
        // Dopo aver creato tutto il metodo possiamo dare nuove direttive a Pizzacontroller
        public static List<Pizze> GetPosts()
        {
            if (PostData.pizzes != null)
            {
              return PostData.pizzes; //se la lista è piena ritorna indietro i post 
            } 

            //se una lista è vuota devo dicharare io cosa fare, instazio un for 
            List<Pizze> NuovaPizza = new List<Pizze> ();
            
            for(int i = 0; i<12; i++)
            {
                Pizze  Margherita = new Pizze (i,"~/img_pizza/Margherita.png", "Margherita", "Pomodoro San Marzano D.O.P., fior di latte di Agerola, basilico e olio evo.", 4.00 );
                NuovaPizza.Add(Margherita);
                Pizze AmericanParty = new Pizze(i, "~/img_pizza/American_Party.png", "American Party", "Becon croccante cheddar provola di Agerola salsiccia sbriciolata crunch di cipolla e salsa bbq.", 9.00);
                NuovaPizza.Add(AmericanParty);
                Pizze Carrettiera = new Pizze(i, "~/img_pizza/Carrettiera.png", "Carrettiera", "Salsiccia di maialino nero, probola IGP, fiarielli", 7.50) ;
                NuovaPizza.Add(Carrettiera);
                Pizze Ereditadellanonna = new Pizze(i, "~/img_pizza/Eredita_Della_Nonna.png", "Eredita della nonna", "Parmigiana di melanzane ricetta tradizionale della nonna, salsiccia di maialino nero sbriciolata, provola affumicata di Agerola, basilico, scaglie di Parmigiano Reggiano 24 mesi e olio evo.", 8.00);
                NuovaPizza.Add(Ereditadellanonna);
                Pizze Fugadalfuturo = new Pizze(i, "~~/img_pizza/Fuda_Dal_Futuro.png", "Fuga da futuro", " Vellutata di zucchine, fior di latte di Agerola, salmone affumicato, ciuffetti di ricotta di fuscella, zest di limone ed olio evo.",12.00);
                NuovaPizza.Add(Fugadalfuturo);
                Pizze AmericanParty = new Pizze(i, "~/img_pizza/American_Party.png", "Margherita", "Becon croccante cheddar provola di Agerola salsiccia sbriciolata crunch di cipolla e salsa bbq.", 9);
                NuovaPizza.Add(AmericanParty);
                Pizze AmericanParty = new Pizze(i, "~/img_pizza/American_Party.png", "Margherita", "Becon croccante cheddar provola di Agerola salsiccia sbriciolata crunch di cipolla e salsa bbq.", 9);
                NuovaPizza.Add(AmericanParty);
                Pizze AmericanParty = new Pizze(i, "~/img_pizza/American_Party.png", "Margherita", "Becon croccante cheddar provola di Agerola salsiccia sbriciolata crunch di cipolla e salsa bbq.", 9);
                NuovaPizza.Add(AmericanParty);
                Pizze AmericanParty = new Pizze(i, "~/img_pizza/American_Party.png", "Margherita", "Becon croccante cheddar provola di Agerola salsiccia sbriciolata crunch di cipolla e salsa bbq.", 9);
                NuovaPizza.Add(AmericanParty);
            }

             //devo salvare il nuovo oggetto che ho creato dentro la lista statica così
             PostData.pizzes = NuovaPizza;
            //restituisco poi le pizze 
             return PostData.pizzes;

        }
    }
}
