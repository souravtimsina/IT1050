using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Order
    {
        public static int ticketCount = 0;



        public static double ticketPriceTotal = 0;

        public static double ticketDiscountTotal = 0;

        public static int concessionCount = 0;

        public static int freePopcornCount = 0;

        public static int freeCandyCount = 0;



        public static double concessionPriceTotal = 0;





        public static void GetTicketOrder()

        {



            int adultTicketCount = 0;

            int childTicketCount = 0;

            int seniorTicketCount = 0;





            System.Console.WriteLine("Will you be purchasing matinee or evening tickets?");

            System.Console.WriteLine();

            System.Console.WriteLine("Enter [1] for Matinee or [2] for Evening.");

            System.Console.Write("---> ");




            System.ConsoleKey key;


            while (!GetValidKey(out key)) ;



            if (key == System.ConsoleKey.NumPad1 || key == System.ConsoleKey.D1)

            {

                int matineeTicketCount = 0;

                double adultMatineePrice = 5.99;

                double childMatineePrice = 3.99;

                double seniorMatineePrice = 4.50;



                System.Console.WriteLine();

                System.Console.WriteLine("+--------------+");

                System.Console.WriteLine(" Day Prices");

                System.Console.WriteLine("+--------------+");

                System.Console.WriteLine(" Adult: $" + adultMatineePrice);

                System.Console.WriteLine(" Child: $" + childMatineePrice);

                System.Console.WriteLine(" Senior: $" + seniorMatineePrice);

                System.Console.WriteLine("+--------------+");

                System.Console.WriteLine();





                System.Console.WriteLine("How many adult tickets would you like to buy?");

                adultTicketCount = AcceptOnlyPositiveIntegers();

                double adultMatineeTotal = adultMatineePrice * adultTicketCount;



                System.Console.WriteLine("How many children tickets would you like to buy?");

                childTicketCount = AcceptOnlyPositiveIntegers();

                double childMatineeTotal = childMatineePrice * childTicketCount;



                System.Console.WriteLine("How many senior tickets would you like to buy?");

                seniorTicketCount = AcceptOnlyPositiveIntegers();

                double seniorMatineeTotal = seniorMatineePrice * seniorTicketCount;



                matineeTicketCount = adultTicketCount + childTicketCount + seniorTicketCount;

                ticketCount = matineeTicketCount;

                ticketPriceTotal = adultMatineeTotal + childMatineeTotal + seniorMatineeTotal;



            }

            else if (key == System.ConsoleKey.NumPad2 || key == System.ConsoleKey.D2)

            {


                int eveningTicketCount = 0;

                double adultEveningPrice = 10.99;

                double childEveningPrice = 6.99;

                double seniorEveningPrice = 8.50;





                System.Console.WriteLine();

                System.Console.WriteLine("+-----------------------------------------------------+");

                System.Console.WriteLine(" Evening Prices");

                System.Console.WriteLine("+-----------------------------------------------------+");

                System.Console.WriteLine(" Adult: $" + adultEveningPrice);

                System.Console.WriteLine(" Child: $" + childEveningPrice);

                System.Console.WriteLine(" Senior: $" + seniorEveningPrice);

                System.Console.WriteLine("+-----------------------------------------------------+");

                System.Console.WriteLine(" Specials");

                System.Console.WriteLine("+-----------------------------------------------------+");

                System.Console.WriteLine(" - Buy at least 3 tickets, get 1 bag of popcorn, free!");

                System.Console.WriteLine("+-----------------------------------------------------+");

                System.Console.WriteLine();





                System.Console.WriteLine("How many adult tickets would you like to buy?");

                adultTicketCount = AcceptOnlyPositiveIntegers();

                double adultEveningTotal = adultEveningPrice * adultTicketCount;



                System.Console.WriteLine("How many children tickets would you like to buy?");

                childTicketCount = AcceptOnlyPositiveIntegers();

                double childEveningTotal = childEveningPrice * childTicketCount;



                System.Console.WriteLine("How many senior tickets would you like to buy?");

                seniorTicketCount = AcceptOnlyPositiveIntegers();

                double seniorEveningTotal = seniorEveningPrice * seniorTicketCount;



                eveningTicketCount = adultTicketCount + childTicketCount + seniorTicketCount;

                ticketCount = eveningTicketCount;

                ticketPriceTotal = adultEveningTotal + childEveningTotal + seniorEveningTotal;



                if (eveningTicketCount >= 3)

                {

                    freePopcornCount++;

                }

            }

        }

        public static void GetConcessionsOrder()

        {

            System.Console.WriteLine();

            System.Console.WriteLine("Would you like to purchase any concessions?");

            System.Console.WriteLine();

            System.Console.WriteLine("Enter [1] for Yes or [2] for No.");

            System.Console.Write("---> ");



            System.ConsoleKey key;

            while (!GetValidKey(out key)) ;



            if (key == System.ConsoleKey.NumPad1 || key == System.ConsoleKey.D1)

            {

                double smallSodaPrice = 3.50;

                double largeSodaPrice = 5.99;

                double hotDogPrice = 3.99;

                double popcornPrice = 4.50;

                double candyPrice = 1.99;



                int smallSodaCount = 0;

                int largeSodaCount = 0;

                int hotDogCount = 0;

                int popcornCount = 0;

                int candyCount = 0;



                System.Console.WriteLine();

                System.Console.WriteLine("+------------------------------------------------------+");

                System.Console.WriteLine(" Concession Prices");

                System.Console.WriteLine("+------------------------------------------------------+");

                System.Console.WriteLine(" Small Soda: $" + smallSodaPrice);

                System.Console.WriteLine(" Large Soda: $" + largeSodaPrice);

                System.Console.WriteLine(" Hot Dog: $" + hotDogPrice);

                System.Console.WriteLine(" Popcorn: $" + popcornPrice);

                System.Console.WriteLine(" Candy: $" + candyPrice);

                System.Console.WriteLine("+-----------------------------------------------------+");

                System.Console.WriteLine(" Specials ");

                System.Console.WriteLine("+-----------------------------------------------------+");

                System.Console.WriteLine(" - Buy popcorn & a large soda, get $2 off your ticket");

                System.Console.WriteLine(" - Buy 3 candies, get 1 free");

                System.Console.WriteLine("+-----------------------------------------------------+");

                System.Console.WriteLine();



                System.Console.WriteLine("How many small sodas would you like to buy?");

                smallSodaCount = AcceptOnlyPositiveIntegers();

                double smallSodaTotal = smallSodaCount * smallSodaPrice;



                System.Console.WriteLine("How many large sodas would you like to buy?");

                largeSodaCount = AcceptOnlyPositiveIntegers();

                double largeSodaTotal = largeSodaCount * largeSodaPrice;



                System.Console.WriteLine("How many hot dogs would you like to buy?");

                hotDogCount = AcceptOnlyPositiveIntegers();

                double hotDogTotal = hotDogCount * hotDogPrice;



                System.Console.WriteLine("How many bags of popcorn would you like to buy?");

                popcornCount = AcceptOnlyPositiveIntegers();

                double popcornTotal = popcornCount * popcornPrice;



                System.Console.WriteLine("How many bags of candy would you like buy?");

                candyCount = AcceptOnlyPositiveIntegers();

                double candyTotal = candyCount * candyPrice;





                concessionCount = smallSodaCount + largeSodaCount + hotDogCount + popcornCount + candyCount;

                concessionPriceTotal = smallSodaTotal + largeSodaTotal + hotDogTotal + popcornTotal + candyTotal;



                while (popcornCount >= 1 && largeSodaCount >= 1 && ticketPriceTotal >= 0)

                {

                    popcornCount--;

                    largeSodaCount--;

                    if (ticketPriceTotal >= 2)

                    {

                        ticketDiscountTotal += 2;

                        ticketPriceTotal -= 2;

                    }

                    else if (ticketPriceTotal < 2 && ticketPriceTotal > 0)

                    {

                        ticketDiscountTotal = ticketDiscountTotal + ticketPriceTotal;

                        ticketPriceTotal = 0;

                    }

                }



                while (candyCount >= 3)

                {

                    freeCandyCount++;

                    candyCount -= 3;

                }

            }

            else if (key == System.ConsoleKey.NumPad2 || key == System.ConsoleKey.D2)

            {

                System.Console.WriteLine();

                System.Console.WriteLine("No concessions added.");

                System.Console.WriteLine();

            }

        }


        private static int AcceptOnlyPositiveIntegers()

        {

            int positiveInteger = -1;

            while (positiveInteger < 0)

            {

                System.Console.Write("---> ");

                int count;

                if (int.TryParse(System.Console.ReadLine(), out count) && count > -1) 
                {

                    positiveInteger = count;

                }

                else

                {

                    System.Console.ForegroundColor = System.ConsoleColor.Red;

                    System.Console.WriteLine("Please enter a positive number.");

                    System.Console.ResetColor();

                }

            }

            return positiveInteger;

        }

        private static bool GetValidKey(out System.ConsoleKey key)

        {

            key = System.Console.ReadKey(true).Key;



            return key == System.ConsoleKey.NumPad1 || key == System.ConsoleKey.NumPad2 || key == System.ConsoleKey.D1 || key == System.ConsoleKey.D2;

        }
    }
}
 
