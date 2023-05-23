using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*• Use an appropriate loop to display the menu and the rest of the program. The loop
             body should be executed at least once before the loop condition is checked.
          - The loop should be controlled by the state of one of your custom methods*/

            do
            {

                //Display menu
                Console.Clear();
                Console.WriteLine("-------------------MENU-------------------------------------------------------------");
                Console.WriteLine("\nChoose an option from the list below:");
                Console.WriteLine("   (1) Chicken Biryani                    \tR45 only");
                Console.WriteLine("   (2) Wors roll                        \tR35 only");
                Console.WriteLine("   (3) Beef burger with small chips      \tR65 only");
                Console.WriteLine("   (4) Deluxe kota                       \tR30 only");
                Console.WriteLine("   (5) Breakfast special                 \tR35 only");
                Console.WriteLine("   (6) Vegeterian wrap                   \tR45 only");

                // Use a switch structure to cycle through the menu options.
                Console.Write("\nPlease select the order number: ");
                int iOrderNumber = int.Parse(Console.ReadLine());


               /* -For each case, you must also call the GenerateOrder method.
                - The default case should handle user error 
                */

                switch (iOrderNumber)
                {

                    case 1:
                        GenerateOrder(45, "Quantity: ");
                        break;
                    case 2:
                        GenerateOrder(35, "Quantity: ");
                        break;
                    case 3:
                        GenerateOrder(65, "Quantity: ");
                        break;
                    case 4:
                        GenerateOrder(30, "Quantity: ");
                        break;
                    case 5:
                        GenerateOrder(35, "Quantity: ");
                        break;
                    case 6:
                        GenerateOrder(45, "Quantity: ");
                        break;
                    default:
                        Console.WriteLine("Invalid entry.Please select an option from the list");
                        Console.WriteLine("Press any key to try again");
                        Console.ReadKey();
                        break;
                }
                Console.WriteLine("-------------THANK YOU-----------------------------------------------");




            } while (isAnotherOne());


            //Allow the user to read Output
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();

        }

        //A method named Total Price that returns a decimal and accepts the quantity of meal items ordered and cost per meal as parameters
        //The purpose of this method is just to calculate and return the total price
        private static decimal TotalPrice(int iQuantityOfMealItems, decimal mCostPerMeal)
        {

            //Calculate total price
            decimal mTotalPrice = iQuantityOfMealItems * mCostPerMeal;
            return mTotalPrice;

        }


        /*A GenerateOrder method that returns nothing but accepst a decimal parameter.
        * The method should also prompt the user for the quantity of menu items to order
        * The TotalPrice method should be called from within the Generate order method
        */

        private static void GenerateOrder(decimal mPriceOfOrder, string sMenuItemsToOrder)
        {
            //Ask the user for the quantity of items to order
            Console.Write(sMenuItemsToOrder);
            string sOrderItems = Console.ReadLine();
            int iOrderItems = int.Parse(sOrderItems);

            /* You must call the TotalPrice method from within the GenerateOrder
              method to calculate the total price of the meal order */


            //Number of meals
            Console.WriteLine("\nNumber of meals: {0} ", iOrderItems);
            //Price per meal
            Console.WriteLine("Price per meal: {0:C} ", mPriceOfOrder);

            //Total price
            Console.WriteLine("Total Price: {0:C} ", TotalPrice(iOrderItems, mPriceOfOrder));

            

            


        }

        /*A method named isAnotherOne that returns a bool.
        The method should prompt the user for another Customer order and return the bool result of the user's response
        */

        private static bool isAnotherOne()
        {
            //prompt the user for another Customer order
            Console.Write("\nNext customer (Y/N)?: ");
            return Console.ReadLine().ToUpper() == "Y";
         

        }



    }

        
    
}
