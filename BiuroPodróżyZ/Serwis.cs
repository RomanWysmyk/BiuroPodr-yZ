using System;
using System.Collections.Generic;

namespace BiuroPodróżyZ
{
    class Serwis

    {
        public List<Place> listOfPlaces3star = new List<Place>();
        public List<Place> listOfPlaces4star = new List<Place>();
        public List<Place> listOfPlaces5star = new List<Place>();

        Place CancunBayResort = new Place("Cancun Bay Resort", "Meksyk", 4, 450);
        Place IberostarQuetzal = new Place("Iberostar Quetzal", "Meksyk", 5, 690);
        Place ImperialLagunaByFaranda = new Place("Imperial Laguna by Faranda", "Meksyk", 3, 320);
        Place Playacalida = new Place("Playacalida", "Hiszpania", 5, 600);
        Place PaliaPuertoDelSol = new Place("Palia Puerto del Sol", "Hiszpania", 3, 240);
        Place PlayaRealResort = new Place("Playa Real Resort", "Hiszpania", 4, 380);
        Place SeaGull = new Place("Sea Gull", "Egipt", 3, 270);
        Place ContinentalHurghada = new Place("Continental Hurghada", "Egipt", 4, 360);
        Place SharmGrandPlaza = new Place("Sharm Grand Plaza", "Egipt", 5, 620);
        Place IkarosHotel = new Place("Ikaros Hotel", "Grecja", 3, 220);
        Place LabrandaSandyBeachResort = new Place("Labranda Sandy Beach Resort", "Grecja", 5, 580);
        Place LidaCorfu = new Place("Lida Corfu", "Grecja", 4, 310);
        Place MyttBeachHotel = new Place("Mytt Beach Hotel", "Tajlandia", 5, 720);
        Place NovotelRayong = new Place("Novotel Rayong", "Tajlandia", 4, 410);
        Place CholchanPattayaResort = new Place("Cholchan Pattaya Resort", "Tajlandia", 3, 290);
        
        public Serwis()
        {
            listOfPlaces4star.Add(CancunBayResort);
            listOfPlaces5star.Add(IberostarQuetzal);
            listOfPlaces3star.Add(ImperialLagunaByFaranda);
            listOfPlaces5star.Add(Playacalida);
            listOfPlaces3star.Add(PaliaPuertoDelSol);
            listOfPlaces4star.Add(PlayaRealResort);
            listOfPlaces3star.Add(SeaGull);
            listOfPlaces4star.Add(ContinentalHurghada);
            listOfPlaces5star.Add(SharmGrandPlaza);
            listOfPlaces3star.Add(IkarosHotel);
            listOfPlaces5star.Add(LabrandaSandyBeachResort);
            listOfPlaces4star.Add(LidaCorfu);
            listOfPlaces5star.Add(MyttBeachHotel);
            listOfPlaces4star.Add(NovotelRayong);
            listOfPlaces3star.Add(CholchanPattayaResort);
        }

        public void showThreeRandomPromo()
        {

            Console.WriteLine("DZISIEJSZE PROMOWANE OFERTY");
            Console.WriteLine("----------------------------");
            
            int finalCostPer_1_Adult=0;
            int baseCost=0;
            
            int randomNumberOfOffer1 = selectRandomOfferFrom_1_to_5();
            int randomNumberOfOffer2 = selectRandomOfferFrom_1_to_5();
            int randomNumberOfOffer3 = selectRandomOfferFrom_1_to_5();

            int p1 = listOfPlaces3star[randomNumberOfOffer1].showOffer(3);
            int p2 = listOfPlaces4star[randomNumberOfOffer2].showOffer(4);            
            int p3 = listOfPlaces5star[randomNumberOfOffer3].showOffer(5);
            Console.WriteLine("PROSZĘ PODAĆ NUMER WYBRANEJ OFERTY");
            String userInput_selectNumberOfOffer_from_1_to_3 = Console.ReadLine();

            if (userInput_selectNumberOfOffer_from_1_to_3.Equals("1"))
            {
                Console.WriteLine(p1);
                baseCost = p1;
                finalCostPer_1_Adult = listOfPlaces3star[randomNumberOfOffer1].prizePerDayAdult;
                calculateFullOffer(finalCostPer_1_Adult);               
            }
            else if (userInput_selectNumberOfOffer_from_1_to_3.Equals("2"))
            {                
                baseCost = p2;
                finalCostPer_1_Adult = listOfPlaces4star[randomNumberOfOffer2].prizePerDayAdult;
                calculateFullOffer(finalCostPer_1_Adult);
            }
            else if (userInput_selectNumberOfOffer_from_1_to_3.Equals("3"))
            {               
                baseCost=p3;
                finalCostPer_1_Adult = listOfPlaces5star[randomNumberOfOffer3].prizePerDayAdult;
                calculateFullOffer(finalCostPer_1_Adult);
            }
            else
            {
                Console.WriteLine("Nie ma takiej oferty");
            }

        }
        void calculateFullOffer(int finalCost)
        {
            int howManyAdults;
            int howManyChildren;
            Console.WriteLine("Ile dorosłych?");
            howManyAdults = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ile dzieci?");
            howManyChildren = Convert.ToInt32(Console.ReadLine());

            finalCost = finalCost * howManyAdults + ((finalCost * howManyChildren) / 2);


            Console.WriteLine("Całkowity koszt wyjazdu to " + finalCost + " PLN");
        }


        public static void hotelRatingCovert(int rating)
        {
            String finalRating = "";

            for (int i = 1; i <= rating; i++)
            {
                if (rating != i)
                {
                    finalRating += "*";
                }
                else
                {
                    finalRating += "*";
                    Console.Write(" (" + finalRating + ")");
                    break;
                }
            }

        }

        public static int setMealCost(int rating)
        {
            if (rating == 3)
            {
                return 0;
            }
            return 1200;
        }

        public static int displayDateOfOffer(int howManyDays)
        {
            var baseDate = new DateTime(2022, 06, 15);
            var sevenDays = new DateTime(2022, 06, 22);
            var tenDays = new DateTime(2022, 06, 25);
            var fourteenDays = new DateTime(2022, 06, 29);

            Console.Write("TERMIN: ");
            Console.Write(baseDate.ToShortDateString());
            Console.Write(" - ");

            if (howManyDays == 7)
            {
                Console.Write(sevenDays.ToShortDateString());
                Console.WriteLine(" (7 dni)");
                return 7;

            }
            else if (howManyDays == 10)
            {
                Console.Write(tenDays.ToShortDateString());
                Console.WriteLine(" (10 dni)");
                return 10;
            }
            else
            {
                Console.Write(fourteenDays.ToShortDateString());
                Console.WriteLine(" (14 dni)");
                return 14;
            }
        }

        public static int selectRandomOfferFrom_1_to_5()
        {
            int randomNumberOfOffer = 0;
            var random = new Random();
            randomNumberOfOffer = random.Next(1, 5);
            return randomNumberOfOffer;
        }

    }
}
