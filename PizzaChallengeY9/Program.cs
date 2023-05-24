using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PizzaChallengeY9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Create an array to store various pizza toppings
            //2.Ask the user how many toppings they require
            //3.For each required topping, ask the user which topping they want
            //    a.This should only ask the correct number of times
            //        i.e.g. if they want three toppings ask three times
            //4.Check to see if the pizza topping is available
            //    a. If not they need to choose one that is
            //5.Check they have not asked for the same topping twice
            //    a.If they do choose a different topping
            //6.Ask for the size of the pizza
            //    a.Small, Medium, Large
            //7.Calculate the cost
            //    a.Small = £2.50
            //    b.Medium = £4.50
            //    c.Large = £7.25
            //    d.Toppings = 75p each
            //8.Extension
            //    a.Ask how many pizzas they want and process the whole order
            //    b.Add discount if the total cost is greater than £20
            //        i. 10 % discount
            //    c.Ask if they need delivery
            //        i. £3.50 if under £25
            //        ii.Free for £25 or more

            string[] toppings = { "Ham", "Mushroom", "Chicken", "Pineapple", "Pepperoni", "Onions" };
            int numToppings;
            Console.Write("How many toppings do you want?: ");
            numToppings = Convert.ToInt32(Console.ReadLine());
            string[] toppingsToUse = new string[numToppings];
            for (int i = 0; i < numToppings; i++)
            {
                string topChoice = "";
                bool validTopping = false;
                while (!validTopping)
                {
                    validTopping = true;
                    Console.Write($"Enter topping {i + 1}: ");
                    topChoice = Console.ReadLine();
                    if (!toppings.Contains(topChoice))
                    {
                        Console.WriteLine("Topping not available! Please try again.");
                        validTopping = false;
                    }
                    else if (toppingsToUse.Contains(topChoice))
                    {
                        Console.WriteLine("You already have that one!  Please try again.");
                        validTopping = false;
                    }

                }
                toppingsToUse[i] = topChoice;
            }
            foreach (string topping in toppingsToUse)
            {
                Console.WriteLine(topping);
            }
            Console.Write("Enter size of Pizza (small/medium/large): ");
            string pizzaSize = Console.ReadLine().ToLower();
            double cost = 0.0;
            if (pizzaSize == "small")
            {
                cost = 2.5;
            }
            else if (pizzaSize == "medium")
            {
                cost = 4.5;
            }
            else
            {
                cost = 7.25;
            }
            cost += numToppings * 0.75;
            Console.WriteLine($"The total cost for your pizza is £{cost.ToString("0.00")}");
        }
    }
}
