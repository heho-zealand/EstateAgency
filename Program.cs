using System;

namespace EstateAgency
{
    class Program
    {
        enum EstateType {Hus, Lejlighed, Rækkehus, Sommerhus}
        
        static void Main(string[] args)
        {
            

            EstateCatalog estateCatalog = new EstateCatalog();
            BuyerCatalog buyerCatalog = new BuyerCatalog();

            Seller seller = new Seller("Peter Madsen", "Ukendt", "12345678", "PM@hotmail.com");

            estateCatalog.AddEstate(new Estate("Hus", "Mågevej 2, 4000 Roskilde", 4500000, 250, 6, seller));
            estateCatalog.AddEstate(new Estate("Hus", "Motelvej 7, 4000 Roskilde", 2500000, 150, 4, seller));

            seller = new Seller("Gurli Margrete", "Highway 5, 8700", "23232323", "GM@gmail.com");
            estateCatalog.AddEstate(new Estate("Lejlighed", "Fasanvej 42, København Ø", 1200000, 75, 3, seller));


        }
    }
}
