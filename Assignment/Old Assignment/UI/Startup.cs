using System;
using System.Collections.Generic;
using Models;
using Service;

namespace UI
{
    public class Startup
    {
        public static void Main()
        {
            PersonDetails obj = new PersonDetails();
            int index;

            do
            {
                DisplayMenu();
                index = GetMenuChoice();

                switch (index)
                {
                    case 1:
                        Console.WriteLine("\nDISPLAY LIST SELECTED");
                        obj.Display();
                        break;
                    case 2:
                        Console.WriteLine("\nADDITION TO LIST SELECTED");
                        obj.Add();
                        break;
                    case 3:
                        Console.WriteLine("\nDELETE OPTION SELECTED");
                        obj.Delete();
                        break;
                    case 4:
                        Console.WriteLine("\nMODIFICATION OF LIST ITEMS SELECTED");
                        obj.Modify();
                        break;
                    case 5:
                        Console.WriteLine("\nSEARCHING OF LIST ITEMS SELECTED");
                        obj.Search();
                        break;
                    case 6:
                        Console.WriteLine("\nSORTING OF LIST ITEMS SELECTED");
                        obj.Sort();
                        break;
                    case 7:
                        Console.WriteLine("\nFILTERING SELECTED");
                        obj.Filter();
                        break;
                    case 8:
                        return;
                    default:
                        Console.WriteLine("\nWrong Input Entered, Please Try Again");
                        break;
                }

                if (index != 6)
                {
                    Console.WriteLine("Choose Another option\n");
                }
            } while (index != 8);
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\n*********** Function Menu ***********\n");
            Console.WriteLine("1. Display List");
            Console.WriteLine("2. Add an item");
            Console.WriteLine("3. Delete an Item ");
            Console.WriteLine("4. Modify an Item ");
            Console.WriteLine("5. Search an Item");
            Console.WriteLine("6. Sort List");
            Console.WriteLine("7. Filter List");
            Console.WriteLine("8. Exit the Program");
        }

        static int GetMenuChoice()
        {
            Console.Write("\nEnter Your Choice: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
