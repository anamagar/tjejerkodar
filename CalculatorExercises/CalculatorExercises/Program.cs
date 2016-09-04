using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//First tjejerkodar in Barcelona
namespace CalculatorExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //You have a company that it sell TV and set up box,
            //Calculate the total price when a customer buy 2 TVs and 1 set up box.
            //Tv cost 5000kr moms 25%
            //set up 2000kr, moms 20%

            //Calculate the total price:
            double total_price = 5000 * 2 * 1.25 + 2000 * 1 * 1.20;

            Console.WriteLine("Total price :" + total_price + "kr");

            

            //Write each value in a variable

            int tvCost = 5000;
            double tvMoms = 0.25;
            int numberOfTvs = 2;

            int setUpBoxCost = 2000;
            double setUpBoxMoms = 0.20;
            int numberOfSetUpBox = 1;

            double priceOfTVs = tvCost * numberOfTvs;
            double totalPriceOfTVs = priceOfTVs + (priceOfTVs * tvMoms);

            double priceOfSetUpBox = setUpBoxCost * numberOfSetUpBox;
            double totalPriceOfSetUpBox = priceOfSetUpBox + (priceOfSetUpBox * setUpBoxMoms);

            double totalPrice2 = totalPriceOfSetUpBox + totalPriceOfTVs;
            Console.WriteLine("Total price :" + totalPrice2 + "kr");

            //Write the same program but use function
            Console.WriteLine("Total price :" + totalPrice() + "kr");

            //Function with argumnets 
            Console.WriteLine("Total price :" + totalPrice(5000, 2, 2000, 1) + "kr");

            //And for a customer that buy 3 setupBox
            Console.WriteLine("Total price for 3 setupBox :" + totalPrice(5000, 2, 2000, 3) + "kr");

            //What if the moms for the setupBox change to 30%
            Console.WriteLine("Total price with setup moms to 30:" + totalPrice(5000, 2, 2000, 3, 0.25, 0.30) + "kr");

            //differents country with difference taxes, What will be the cost in france
            // FR 20% Tv 15% setUpBox
            // IT 22% Tv 14% setUpBox
            // SW 25% Tv 30% setUpBox

            double[] taxesInFrance = { 0.20, 0.15 };
            double[] taxesInItaly = { 0.22, 0.14 };
            double[] taxesInSweden = { 0.25, 0.30 };

            String customerOrigin = "FR";
            if (customerOrigin == "FR") {
                totalPrice(5000, 2, 2000, 1, taxesInFrance[0], taxesInFrance[1]);

            }

            //What will be the cost in Italy?

            totalPrice(5000, 2, 2000, 1, "IT");

            //If the price is higger than 10000 apply 5% discount 

            Console.ReadKey();
        }

        public static double totalPrice(double tvCost, int numberOfTvs, double setUpBoxCost, int numberOfSetUpBox, String country) {

            double[] taxesInFrance = { 0.20, 0.15 };
            double[] taxesInItaly = { 0.22, 0.14 };
            double[] taxesInSweden = { 0.25, 0.30 };

            double totalPriceByCountry = 0;
            if (country == "FR")
            {
                totalPriceByCountry = totalPrice(5000, 2, 2000, 1, taxesInFrance[0], taxesInFrance[1]);

            }
            else if (country == "IT")
            {
                totalPriceByCountry = totalPrice(5000, 2, 2000, 1, taxesInItaly[0], taxesInItaly[1]);
            }
            else if (country == "SW") {
                totalPriceByCountry = totalPrice(5000, 2, 2000, 1, taxesInSweden[0], taxesInSweden[1]);
            }


            return totalPriceByCountry;
        }

        public static double totalPrice() {
            int tvCost = 5000;
            double tvMoms = 0.25;
            int numberOfTvs = 2;

            int setUpBoxCost = 2000;
            double setUpBoxMoms = 0.20;
            int numberOfSetUpBox = 1;

            double priceOfTVs = tvCost * numberOfTvs;
            double totalPriceOfTVs = priceOfTVs + (priceOfTVs * tvMoms);

            double priceOfSetUpBox = setUpBoxCost * numberOfSetUpBox;
            double totalPriceOfSetUpBox = priceOfSetUpBox + (priceOfSetUpBox * setUpBoxMoms);

            double totalPrice = totalPriceOfSetUpBox + totalPriceOfTVs;
            return totalPrice;
        }

        public static double totalPrice(double tvCost, int numberOfTvs, double setUpBoxCost, int numberOfSetUpBox)
        {
            double tvMoms = 0.25;
            double setUpBoxMoms = 0.20;
            
            double priceOfTVs = tvCost * numberOfTvs;
            double totalPriceOfTVs = priceOfTVs + (priceOfTVs * tvMoms);

            double priceOfSetUpBox = setUpBoxCost * numberOfSetUpBox;
            double totalPriceOfSetUpBox = priceOfSetUpBox + (priceOfSetUpBox * setUpBoxMoms);

            double totalPrice = totalPriceOfSetUpBox + totalPriceOfTVs;
            return totalPrice;
        }

        public static double totalPrice(double tvCost, int numberOfTvs, double setUpBoxCost, int numberOfSetUpBox, double tvMoms, double setUpBoxMoms)
        {
            double priceOfTVs = tvCost * numberOfTvs;
            double totalPriceOfTVs = priceOfTVs + (priceOfTVs * tvMoms);

            double priceOfSetUpBox = setUpBoxCost * numberOfSetUpBox;
            double totalPriceOfSetUpBox = priceOfSetUpBox + (priceOfSetUpBox * setUpBoxMoms);

            double totalPrice = totalPriceOfSetUpBox + totalPriceOfTVs;
            return totalPrice;
        }
    }
}
