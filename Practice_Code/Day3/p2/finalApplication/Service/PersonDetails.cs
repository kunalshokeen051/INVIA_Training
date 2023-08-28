using System;
using System.Collections.Generic;
using Models;

namespace Service;

public class PersonDetails
{
    int temp;
    List<Person> list = new List<Person>();

    public void InitList()
    {
        list.Add(
            new Person
            {
                Id = 0,
                Name = "Kunal Shokeen",
                Age = 23
            }
        );
        list.Add(
            new Person
            {
                Id = 1,
                Name = "Kunal",
                Age = 22
            }
        );
        list.Add(
            new Person
            {
                Id = 2,
                Name = "Kunal Sharma",
                Age = 24
            }
        );
    }

    public void Display()
    {
        if (list.Count == 0)
        {
            Console.WriteLine("No Data Found!");
        }
        else
        {
            Console.WriteLine("List is");
            foreach (Person p in list)
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("id of the person is:" + p.Id);
                Console.WriteLine("Name of the person is: " + p.Name);
                Console.WriteLine("Age of the person is:" + p.Age);
                Console.WriteLine("");
            }
        }
    }

    public void Display(int position)
    {
        if (list.Count == 0)
        {
            Console.WriteLine("No Data Found!");
        }
        else
        {
            Console.WriteLine("details of person is");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("id of the person is:" + list[position].Id);
            Console.WriteLine("Name of the person is: " + list[position].Name);
            Console.WriteLine("Age of the person is:" + list[position].Age);
            Console.WriteLine("");
        }
    }

    public void Add()
    {
        Console.WriteLine("Enter the name of the person");
        String AddName = Console.ReadLine();
        Console.WriteLine("Enter the Age of the person");
        int AddAge = Convert.ToInt32(Console.ReadLine());
        list.Add(
            new Person
            {
                Id = list.Count,
                Name = AddName,
                Age = AddAge
            }
        );
        Console.WriteLine("Item was successfully added");
        Display();
        Console.WriteLine("press 1 to enter another item or press 2 to choose another option.");
        temp = Convert.ToInt32(Console.ReadLine());
        if (temp == 1)
        {
            Add();
        }
        else
            return;
    }

    public void Delete()
    {
        Console.WriteLine(
            "Enter the Id of the person to delete or press 00 to see the list first..."
        );
        int SearchId = Convert.ToInt32(Console.ReadLine());
        if (SearchId == 00)
        {
            Display();
        }
        var position = 0;
        foreach (var item in list)
        {
            if (item.Id == SearchId)
                position = item.Id;
        }
        if (position != 0)
        {
            list.RemoveAt(position);
            Console.WriteLine("Item at" + "ID:" + " " + position + " " + "successfully deleted");
            Display();
        }
        else
        {
            Console.WriteLine("Item not found");
        }
    }

    public void Modify()
    {
        string NewName;
        int NewAge;
        Console.WriteLine("Enter the Id of the person to delete");
        int SearchId = Convert.ToInt32(Console.ReadLine());
        int position = 0;
        foreach (var item in list)
        {
            if (item.Id == SearchId)
                position = item.Id;
            else
                Console.WriteLine("Item not found");
            return;
        }
        Console.WriteLine("Enter new Name:");
        NewName = Console.ReadLine();
        Console.WriteLine("Enter new Age:");
        NewAge = Convert.ToInt32(Console.ReadLine());
        list[position].Name = NewName;
        list[position].Age = NewAge;
        Console.WriteLine("Item at" + "ID:" + position + "successfully Updated");
        Display();
    }

    public void Search()
    {
        int SearchId = 0;
        string SearchName = "";
        int position = 0;
        Console.WriteLine("1. Search by ID");
        Console.WriteLine("2. Search by Name");
        Console.WriteLine("");
        Console.WriteLine("Select an option:");
        int option = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        if (option == 1)
        {
        Console.WriteLine("Enter ID:");
            SearchId = Convert.ToInt32(Console.ReadLine());
            foreach (var item in list)
            {
                if (item.Id == SearchId)
                {
                    position = item.Id;
                }
            }
        }
        else if (option == 2)
        {
        Console.WriteLine("");
        Console.WriteLine("Enter Name:");
            SearchName = Console.ReadLine();
            foreach (var item in list)
            {
                if (item.Name == SearchName)
                {
                    position = item.Id;
                }
            }
        }
        Display(position);
    }
}
