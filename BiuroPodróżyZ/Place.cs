using System;

namespace BiuroPodróżyZ
{
    class Place
    {
        public Place( string name, string country, int rating, int basePrize)
        {
            
            this.name = name;
            this.country = country;
            this.rating = rating;
            this.basePrize = basePrize;
            

        }
        
        String name;
        String country;
        int rating;
        int basePrize;     
        public int meal;
        int howManyDays;
        int costOfFlight;
        public int prizePerDayAdult;

        public int showOffer(int rating)
        {

            if (rating == 3)
            {
                Console.WriteLine("NUMER: 1");               
            }
            else if (rating == 4)
            {
                Console.WriteLine("NUMER: 2");              
            }
            else
            {
                Console.WriteLine("NUMER: 3");           
            }

            Console.WriteLine("KRAJ: " + country);

            if (rating == 3)
            {
                Serwis.displayDateOfOffer(7);
                howManyDays = 7;
            }
            else if (rating == 4)
            {               
                Serwis.displayDateOfOffer(10);
                howManyDays = 10;
            }
            else
            {              
                Serwis.displayDateOfOffer(14);
                howManyDays = 14;
            }
            
            if(country.Equals("Hiszpania")|| country.Equals("Grecja"))
            {
                costOfFlight = 1000;
            } else if (country.Equals("Egipt")){
                costOfFlight = 1500;
            }
            else if (country.Equals("Tajlandia")){
                costOfFlight = 2000;
            }
            else if (country.Equals("Meksyk")){
                costOfFlight = 2500;
            }
                         
            Console.Write("HOTEL: " + name + " ");
            Serwis.hotelRatingCovert(rating);
            Console.WriteLine();
            meal = Serwis.setMealCost(rating);
            if (meal == 0)
            {
                Console.WriteLine("WYŻYWIENIE: śniadania ");
            } else Console.WriteLine("WYŻYWIENIE: All inclusive");
            prizePerDayAdult = basePrize * howManyDays + costOfFlight + meal;
            Console.WriteLine("CENA: " + prizePerDayAdult + " PLN/OS");
            Console.WriteLine("---------------------------");
            
            return basePrize;
        }




    }
}
