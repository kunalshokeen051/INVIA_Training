using System;
using System.Collections.Generic;
using Models;
using Service;

namespace UI;

public class Startup
{
    static bool exit = false;

    public static void Main()
    {
        PersonDetails obj = new PersonDetails();
                    Console.WriteLine("");
                    Console.WriteLine("*********** Function Menu ***********");
                    Console.WriteLine("");
        Console.WriteLine("1. Display List");
        Console.WriteLine("2. Add an item");
        Console.WriteLine("3. Delete an Item ");
        Console.WriteLine("4. Modify an Item ");
        Console.WriteLine("5. Search an Item");
        Console.WriteLine("6. Exit the Program");
        Console.WriteLine("");
        Console.WriteLine("Enter Your Choice: ");
        int Index = Convert.ToInt32(Console.ReadLine());
        while (!Startup.exit)
        {
            switch (Index)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("DISPLAY lIST SELECTED");
                    obj.Display();
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("ADDITION TO LIST SELECTED");
                    obj.Add();
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("DELETE OPTION SELECTED");
                    obj.Delete();
                    break;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("MODIFICATION OF LIST ITEMS SELECTED");
                    obj.Modify();
                    break;
                case 5:
                    Console.WriteLine("");
                    Console.WriteLine("SEARCHING OF LIST ITEMS SELECTED");
                    obj.Search();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Wrong Input Entered, Please Try Again");
                    break;
            }

            if (Index != 6)
            {
                // After adding a person, go back to the main menu
                Console.WriteLine("Choose Another option");
                Console.WriteLine("");
                Console.WriteLine("1. Display List");
                Console.WriteLine("2. Add an item");
                Console.WriteLine("3. Delete an Item ");
                Console.WriteLine("4. Modify an Item ");
                Console.WriteLine("5. Search an Item");
        Console.WriteLine("6. Exit the Program");
                Console.WriteLine("");
                Index = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
