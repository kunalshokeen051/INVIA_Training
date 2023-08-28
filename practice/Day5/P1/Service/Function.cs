using System;
using System.Collections.Generic;
using Models;

namespace Service
{
    public class Function
    {
        public int Counter = 5;
        public dynamic Total = 0.0;
        List<Data> list = null;

        public Function()
        {
            list = new List<Data>();
            list.Add(
                new Data
                {
                    Index = 1,
                    Item = "milk",
                    Price = 2.34,
                }
            );
            list.Add(
                new Data
                {
                    Index = 2,
                    Item = "eggs",
                    Price = 12.124,
                }
            );
            list.Add(
                new Data
                {
                    Index = 3,
                    Item = "fruits",
                    Price = 56.32,
                }
            );
            list.Add(
                new Data
                {
                    Index = 4,
                    Item = "sugar",
                    Price = 1.4,
                }
            );
        }

        public void AddToCart(string NewItem, double NewPrice)
        {
            list.Add(
                new Data
                {
                    Index = Counter,
                    Item = NewItem,
                    Price = NewPrice,
                }
            );
            Counter++;
            ShowCart();
        }

        public void ShowCart()
        {
            Console.WriteLine("\n ******** Cart Items  ********");
            Console.WriteLine("INDEX\tITEMS\tPRICE");
            Total = 0;
            foreach (var item in list)
            {
                Console.WriteLine(item.Index + ".\t" + item.Item + "\t" + '$' + item.Price);
                Total += item.Price;
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\t\tTotal:\t" + '$' + Total);
            Console.WriteLine("\nList count:" + list.Count);
            Console.ReadKey();
        }

        public void Sort(int option)
        {
            if (option == 1 && list != null)
            {
                Console.WriteLine("DECREMENT SORT SELECTED");
                for (int i = 0; i < list.Count - 1; i++)
                {
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        if (list[i].Price < list[j].Price)
                        {
                            // Console.WriteLine(list[i].Item + list[j].Item);
                            (list[j], list[i]) = (list[i], list[j]);
                            // Console.WriteLine(list[i].Item + list[j].Item);
                        }
                    }
                }
                ShowCart();
            }
            else if (option == 2 && list != null)
            {
                Console.WriteLine("INCREMENT SORT SELECTED");
                for (int i = 0; i < list.Count - 1; i++)
                {
                    for (int j = i + 1; j < list.Count-i; j++)
                    {
                        if (list[i].Price > list[j].Price)
                        {
                            // Console.WriteLine(list[i].Item + list[j].Item);
                            (list[j], list[i]) = (list[i], list[j]);
                            // Console.WriteLine(list[i].Item + list[j].Item);
                        }
                    }
                }
                ShowCart();
            }
            else
            {
                Console.WriteLine("you have entered a wrong Input or the list is empty");
            }
        }

        public void Search(string itemName)
        {
            foreach (var item in list)
            {
                if (item.Item == itemName)
                {
                    Console.WriteLine("INDEX\tITEMS\tPRICE");
                    Console.Write(item.Index + "\t" + item.Item + "\t" + '$' + item.Price);
                    return;
                }
            }
            Console.WriteLine("Item not Found!");
        }

        public void Filter(int option, int QueryPrice)
        {
            if (option == 1)
            {
                var items =
                    from item in list //IEnumerable<string> type
                    where item.Price >= QueryPrice
                    select item;

                    Console.WriteLine("\n----Results----\n");
                    Console.WriteLine("INDEX\tITEMS\tPRICE");
                foreach (var item in items)
                {
                    Console.WriteLine(item.Index + "\t" + item.Item + "\t" + item.Price);
                }
                Console.ReadKey();
            }
            else if (option == 2)
            {
                var items =
                    from item in list //IEnumerable<string> type
                    where item.Price <= QueryPrice
                    select item;

                    Console.WriteLine("\n----Results----\n");
                    Console.WriteLine("INDEX\tITEMS\tPRICE");
                foreach (var item in items)
                {
                    Console.WriteLine(item.Index + "\t" + item.Item + "\t" + item.Price);
                }
                Console.ReadKey();
            }
            else if (option == 3)
            {
                var items =
                    from item in list //IEnumerable<string> type
                    where item.Price > QueryPrice
                    select item;

                    Console.WriteLine("\n----Results----\n");
                    Console.WriteLine("INDEX\tITEMS\tPRICE");
                foreach (var item in items)
                {
                    Console.WriteLine(item.Index + "\t" + item.Item + "\t" + item.Price);
                }
                    Console.ReadKey();
            }
            else if (option == 4)
            {
                var items =
                    from item in list //IEnumerable<string> type
                    where item.Price < QueryPrice
                    select item;

                    Console.WriteLine("\n----Results----\n");
                    Console.WriteLine("INDEX\tITEMS\tPRICE");
                foreach (var item in items)
                {
                    Console.WriteLine(item.Index + "\t" + item.Item + "\t" + item.Price);
                }
                Console.ReadKey();
            }
            else{
                Console.WriteLine("Wrong Input Entered");
            }
        }
    }
}
