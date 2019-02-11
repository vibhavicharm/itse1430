using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {        
        /* Main method
         * Pragram shows the menu to the user and asks to select one selection from 4 choices.
         * If user enters wrong input program asks to enter again and loop untile user enter a valid input.
         * Then go to the next action as user requested.
         */
         static void Main(string[] args)
         {
            int selection;
            int[] meatArray = new int[10];
            int[] vegiesArray = new int[10];
            int pizzaSize = 0, pizzaMeats = 0, pizzaVegies = 0, pizzaSauce = 0, pizzaCheese = 0, pizzaDelivery = 0;
            double sizePrice = 0, saucePrice = 0, meatPrice = 0, vegiesPrice = 0, deliveryPrice = 0, cheesePrice = 0;
            double pizzaTotal = 0;
            string showSize = "", showMeat = "", showVegies = "", showSauce = "", showCheese = "", showDelivery = "";

            do
            {
                // Show Menu
                Console.WriteLine("********** MENU **********\n\n\t(1)New Order\n\t(2)Modify Order\n\t(3)Display Order\n\t(4)Quit\n");
                double cartPrice = 0;
                cartPrice += pizzaTotal;
                Console.WriteLine("The cart price: {0:C}\n", pizzaTotal);
                Console.WriteLine("Please choose your selection (1-4):\n\t1 for New Order\n\t2 for Modify the order\n\t3 for Display order\n\t4 for Quit \n\n");
                selection = Convert.ToInt32(Console.ReadLine());
                while (selection < 1 || selection > 4)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number (1-4): ");
                    selection = Convert.ToInt32(Console.ReadLine());
                }

                switch (selection)
                {
                    case 1:
                        NewOrder(meatArray, vegiesArray, pizzaSize, pizzaMeats, pizzaVegies, pizzaSauce, pizzaCheese, pizzaDelivery, pizzaTotal, sizePrice, saucePrice, meatPrice, vegiesPrice, deliveryPrice, cheesePrice);
                        break;
                    case 2:
                        ModifyOrder(meatArray, vegiesArray, pizzaSize, pizzaMeats, pizzaVegies, pizzaSauce, pizzaCheese, pizzaDelivery, pizzaTotal, sizePrice, saucePrice, meatPrice, vegiesPrice, deliveryPrice, cheesePrice);
                        break;
                    case 3:
                        DisplayOrder(meatArray, vegiesArray, pizzaSize, pizzaMeats, pizzaVegies, pizzaSauce, pizzaCheese, pizzaDelivery, pizzaTotal, sizePrice, saucePrice, meatPrice, vegiesPrice, deliveryPrice, cheesePrice, showSize, showMeat, showVegies, showSauce, showCheese, showDelivery);
                        break;

                    case 4:
                        break;
                }

            } while (selection != 4);
         }


        /// <summary>
        /// New Order choice.
        /// </summary>
        public static void NewOrder(int[] meatArray, int[] vegiesArray, int pizzaSize, int pizzaMeats, int pizzaVegies, int pizzaSauce, int pizzaCheese, int pizzaDelivery, double pizzaTotal, double sizePrice, double saucePrice, double meatPrice, double vegiesPrice, double deliveryPrice, double cheesePrice)
        {
            Console.WriteLine("\nPlease select the size of your pizza (1-3):\n\t1 Small($5)\n\t2 Medium ($6.25)\n\t3 Large ($8.75) ");
            pizzaSize = Convert.ToInt32(Console.ReadLine());
            while (pizzaSize < 1 || pizzaSize > 3)
            {
                Console.WriteLine("Invalid input. Please enter a valid number (1-3): ");
                pizzaSize = Convert.ToInt32(Console.ReadLine());
            }
            string showSize = "";
            if (pizzaSize == 1)
            {
                showSize = "Small";
                sizePrice = 5.00;
            }
            if (pizzaSize == 2)
            {
                showSize = "Medium";
                sizePrice = 6.25;
            }
            if (pizzaSize == 3)
            {
                showSize = "Large";
                sizePrice = 8.75;
            }
            pizzaTotal = sizePrice;
            Console.WriteLine("You have chosen a {0} size pizza and your total for now is {1:C}.", showSize, pizzaTotal);

            int i = 0;
            Console.WriteLine("\nPlease select your Meats: Each option is $0.75 extra.\n\t1 Bacon\n\t2 Ham\n\t3 Pepperoni\n\t4 Sausage\n\t0 Go to next ");
            pizzaMeats = Convert.ToInt32(Console.ReadLine());

            while(pizzaMeats < 0 || pizzaMeats > 4)
            {
                Console.WriteLine("Invalid input. Please enter valid input (0-4): ");
                pizzaMeats = Convert.ToInt32(Console.ReadLine());
            }

            string showMeat = "";
            if(pizzaMeats == 1)
            {
                showMeat = "Bacon";
                meatPrice = 0.75;
            }
            if (pizzaMeats == 2)
            {
                showMeat = "Ham";
                meatPrice = 0.75;
            }
            if (pizzaMeats == 3)
            {
                showMeat = "Pepperoni";
                meatPrice = 0.75;
            }
            if (pizzaMeats == 4)
            {
                showMeat = "Sausage";
                meatPrice = 0.75;
            }
            
            Console.WriteLine("You have chosen {0}.\n", showMeat);
            
            while (pizzaMeats != 0)
            {
                Console.WriteLine("What else do you want to add? Please enter (1-4). If you want to go to next press 0: ");
                pizzaMeats = Convert.ToInt32(Console.ReadLine());
                if (pizzaMeats == 1)
                {
                    showMeat = "Bacon";
                    meatPrice = 0.75;
                }
                if (pizzaMeats == 2)
                {
                    showMeat = "Ham";
                    meatPrice = 0.75;
                }
                if (pizzaMeats == 3)
                {
                    showMeat = "Pepperoni";
                    meatPrice = 0.75;
                }
                if (pizzaMeats == 4)
                {
                    showMeat = "Sausage";
                    meatPrice = 0.75;
                }
                Console.WriteLine("You have chosen {0} and total{1}.\n", showMeat, pizzaTotal);
                pizzaTotal += meatPrice;
            }

            meatArray[pizzaMeats] = i;
            Console.WriteLine("You have selected {0} and your total for now is {1:C}.", meatArray[i], pizzaTotal);

            int j = 0;
            Console.WriteLine("\nPlease select your Vegitables. Each option is $0.50 extra.\nWhen you are done with vegitables enter 0.\n\t1 Black Olives\n\t2 Mushroom\n\t3 Onions\n\t4 Peppers\n\t0 Go to next");
            pizzaVegies = Convert.ToInt32(Console.ReadLine());

            
            while (pizzaVegies < 0 || pizzaVegies > 4)
            {
                Console.WriteLine("Invalid input. Please enter valid input (0-4): ");
                pizzaVegies = Convert.ToInt32(Console.ReadLine());
            }

            vegiesArray[j] = pizzaVegies;
            string showVegies = "";
            if (pizzaVegies == 1)
            {
                showVegies = "Black Olives";
                vegiesPrice = 0.50;
            }
            if (pizzaVegies == 2)
            {
                showVegies = "Mushrooms";
                vegiesPrice = 0.50;
            }
            if (pizzaVegies == 3)
            {
                showVegies = "Onions";
                vegiesPrice = 0.50;
            }
            if (pizzaVegies == 4)
            {
                showVegies = "Peppers";
                vegiesPrice = 0.50;
            }
           
            Console.WriteLine("You have chosen {0}.\n", showVegies);


            while (pizzaVegies != 0)
            {
                Console.WriteLine("What else do you want to add? Please enter (1-4). If you want to go to next press 0: ");
                pizzaVegies = Convert.ToInt32(Console.ReadLine());
                if (pizzaVegies == 1)
                {
                    showVegies = "Black Olives";
                    vegiesPrice = 0.50;
                }
                if (pizzaVegies == 2)
                {
                    showVegies = "Mushrooms";
                    vegiesPrice = 0.50;
                }
                if (pizzaVegies == 3)
                {
                    showVegies = "Onions";
                    vegiesPrice = 0.50;
                }
                if (pizzaVegies == 4)
                {
                    showVegies = "Peppers";
                    vegiesPrice = 0.50;
                }
                Console.WriteLine("You have chosen {0}.\n", showVegies);
                pizzaTotal += vegiesPrice;
                j++;
            }
            
            vegiesArray[pizzaVegies] = j;
            Console.WriteLine("You have selected {0} and your total for now is {1:C}.", vegiesArray, pizzaTotal);

            
            Console.WriteLine("\nPlease select sauce.\n\t1 Traditional ($0)\n\t2 Garlic ($1)\n\t3 Oregano ($1)");
            int sauce = Convert.ToInt32(Console.ReadLine());
            string showSauce = "";
            if (sauce == 1)
            {
                showSauce = "Traditional";
                saucePrice = 0;
            }
            if (sauce == 2)
            {
                showSauce = "Garlic";
                saucePrice = 1;
            }
            if (sauce == 3)
            {
                showSauce = "Oregone";
                saucePrice = 1;
            }
            pizzaTotal += saucePrice;
            Console.WriteLine("You have chosen {0} ({1:C}) sauce. Your total for now is {2:C}.", showSauce, saucePrice, pizzaTotal);

            Console.WriteLine("\nPlease select cheese (1-2):\n\t1 Regular (0)\n\t2 Extra ($1.25)");
            int cheese = Convert.ToInt32(Console.ReadLine());
            string showCheese = "";
            
            if (cheese == 1)
            {
                showCheese = "Regular";
                cheesePrice = 0;
            }
            if (cheese == 2)
            {
                showCheese = "Extra";
                cheesePrice = 1.25;
            }
            pizzaTotal += cheesePrice;
            Console.WriteLine("You have chosen {0} ({1:C}) cheese. Your total for now is {2:C}.", showCheese, cheesePrice, pizzaTotal);

            Console.WriteLine("\nPlease select delivery option (1-2):\n\t1 Take Out (0)\n\t2 Delivery ($2.50)");
            int delivery = Convert.ToInt32(Console.ReadLine());
            string showDelivery = "";
            
            if (delivery == 1)
            {
                showDelivery = "Take out";
                deliveryPrice = 0;
            }
            if (delivery == 2)
            {
                showDelivery = "Delivery";
                deliveryPrice = 2.50;
            }
            pizzaTotal += deliveryPrice;
            Console.WriteLine("You have chosen {0}.", showDelivery);

            //Shows order information and return to the main menu
            DisplayOrder(meatArray, vegiesArray, pizzaSize, pizzaMeats, pizzaVegies, pizzaSauce, pizzaCheese, pizzaDelivery, pizzaTotal, sizePrice, saucePrice, meatPrice, vegiesPrice, deliveryPrice, cheesePrice, showDelivery, showCheese, showMeat, showSauce, showSize, showVegies);

        }

        public static void ModifyOrder(int[] meatArray, int[] vegiesArray, int pizzaSize, int pizzaMeats, int pizzaVegies, int pizzaSauce, int pizzaCheese, int pizzaDelivery, double pizzaTotal, double sizePrice, double saucePrice, double meatPrice, double vegiesPrice, double deliveryPrice, double cheesePrice)
        {
            if(pizzaSize == 0)
            {
                Console.WriteLine("Error! There is no existing orders to modify");
            }
            else
            {
                NewOrder(meatArray, vegiesArray, pizzaSize, pizzaMeats, pizzaVegies, pizzaSauce, pizzaCheese, pizzaDelivery, pizzaTotal, sizePrice, saucePrice, meatPrice, vegiesPrice, deliveryPrice, cheesePrice);
            }
        }

        public static void DisplayOrder(int[] meatArray, int[] vegiesArray, int pizzaSize, int pizzaMeats, int pizzaVegies, int pizzaSauce, int pizzaCheese, int pizzaDelivery, double pizzaTotal, double sizePrice, double saucePrice, double meatPrice, double vegiesPrice, double deliveryPrice, double cheesePrice, string showSize, string showMeat, string showVegies, string showSauce, string showCheese, string showDelivery)
        {
            Console.WriteLine("\n\nYour order information: \n");
            Console.WriteLine("{0} pizza \t\t{1:C}", showSize, sizePrice);
            Console.WriteLine("{0}\t\t{1:C}", showDelivery, deliveryPrice);
            Console.WriteLine("Meats\n\t{0}\t\t{1:C}", showMeat, meatPrice);
            Console.WriteLine("Vegitables\n\t{0}\t\t{1:C}", showVegies, vegiesPrice);
            Console.WriteLine("Sauce\n\t{0}\t{1:C}", showSauce, saucePrice);
            Console.WriteLine("Cheese\n\t{0}\t\t{1:C}", showCheese, cheesePrice);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Total\t\t\t{0:C}", pizzaTotal);
            Console.ReadKey();
        }
        
    }
}
