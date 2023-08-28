using System;
using System.Collections.Generic;
using Models;
using Service;

namespace UI
{
    public class UI
    {
        public string Name = "";
        public double Price = 0.0;
        public bool exit = false;
        public int InputCounter = 0;
        public int option;

        public static void Main()
        {
            UI obj = new();
            Function obj1 = new();
            while (obj.exit == false)
            {
                if (obj.InputCounter != 0)
                {
                    Console.WriteLine(
                        "\n0. Show List\n1. Add another Item\n2. Sort the list \n3. Search an Item\n4. Filter items  \n5. Exit "
                    );
                    var temp = Convert.ToInt32(Console.ReadLine());
                    if (temp == 0)
                    {
                        Console.WriteLine("LIST");
                        obj1.ShowCart();
                    }
                    if (temp == 2)
                    {
                        Console.Write("\n1.Sort in Decresing Order\n2.Sort in Increasing Order\n");
                        var option = Convert.ToInt32(Console.ReadLine());
                        if (option == 1)
                        {
                            obj1.Sort(option);
                        }
                        else if (option == 2)
                        {
                            obj1.Sort(option);
                        }
                    }
                    if (temp == 3)
                    {
                        Console.Write("\nEnter item name to search:\t");
                        var itemName = Console.ReadLine();
                        obj1.Search(itemName);
                    }
                    if (temp == 4)
                    {
                        Console.Write("\nEnter the Limit Price(Whole Number Only):");
                        var LimitValue = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n1.Greater than Equal to the price \n2.Smaller than Equal to the price\n3.Greater than the price\n4.Smaller than the price\n ");
                        var option = Convert.ToInt32(Console.ReadLine());
                        if (option == 1)
                        {
                            obj1.Filter(option,LimitValue);
                        }
                        else if (option == 2)
                        {
                            obj1.Filter(option,LimitValue);
                        }
                        else if (option == 3)
                        {
                            obj1.Filter(option,LimitValue);
                        }
                        else if (option == 4)
                        {
                            obj1.Filter(option,LimitValue);
                        }
                    }
                    if (temp == 5)
                    {
                        obj1.ShowCart();
                        obj.exit = true;
                        Console.WriteLine("\nEnd of Program");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("--------- CART Function ----------");
                }
                Console.Write("\nEnter an Item Name:(Leave blank to go to menu) ");
                obj.Name = Console.ReadLine();
                if (obj.Name != "")
                {
                    Console.Write("\nEnter an Item Price: ");
                    obj.Price = Convert.ToDouble(Console.ReadLine());
                    obj1.AddToCart(obj.Name, obj.Price);
                }
                obj.InputCounter++;
            }
        }
    }
}
