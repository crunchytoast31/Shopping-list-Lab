using System.Reflection.Metadata.Ecma335;

namespace Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<string> Totalgroceries = new List<string>();
                Dictionary<string, decimal> shoppinglist = new Dictionary<string, decimal>();
                shoppinglist.Add("Lettus", 2.54m);
                shoppinglist.Add("Pasta", 4.34m);
                shoppinglist.Add("Mushrooms", 3.66m);
                shoppinglist.Add("Beef", 6.08m);
                shoppinglist.Add("Chicken", 7.70m);
                shoppinglist.Add("Peppers", 1.54m);
                shoppinglist.Add("Onion", 3.22m);
                shoppinglist.Add("Tomato", 2.97m);

                Console.WriteLine("here are the avaliable groceries.");

                foreach (KeyValuePair<string, decimal> kvp in shoppinglist)
                {
                    Console.WriteLine($"{kvp.Key} {kvp.Value}");
                }

                Console.WriteLine("What would you like to add to your cart?");
                string userinput = Console.ReadLine();
                bool grocery = shoppinglist.ContainsKey(userinput);

                foreach (KeyValuePair<string, decimal> kvp in shoppinglist)
                {
                    grocery = shoppinglist.ContainsKey(userinput);
                    if (grocery == true)
                    {
                        Totalgroceries.Add(userinput);
                        Console.WriteLine($"you added {userinput} to cart, that item costs {shoppinglist[userinput]}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("We do not have that item");
                        break;
                    }

                }
                Console.WriteLine("Would you like another item? Y/N");
                string yesorno = Console.ReadLine();
                if (yesorno == "Y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("all the items in your cart are:");
                    Console.WriteLine();
                    decimal cost = 0m;

                    foreach (string input in Totalgroceries)
                    {
                        Console.WriteLine($"{input} {shoppinglist[input]}");
                        cost += shoppinglist[input];
                    }
                    Console.WriteLine($"your total is {cost}");
                    Console.WriteLine("Come again next time");
                    break;
                }


            }









        }




    }
}