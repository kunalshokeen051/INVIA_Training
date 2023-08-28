using System;
using System.Collections.Generic;
using Models;
using Functionality;

namespace Service;

public class PersonDetails : IPersonDetails
{
    int temp;
    int newId;
    List<Person> list = null;

    public PersonDetails()
    {
        list = new List<Person>();
        list.Add(
            new Person
            {
                Id = 1,
                Name = "Kunal Shokeen",
                Age = 23
            }
        );
        list.Add(
            new Person
            {
                Id = 2,
                Name = "Kunal",
                Age = 22
            }
        );
        list.Add(
            new Person
            {
                Id = 3,
                Name = "Kunal Sharma",
                Age = 24
            }
        );
        newId = 4;
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
                Console.WriteLine("--------------------------------");
            }
        }
    }

    public void Display(Person position)
    {
        if (position == null)
        {
            Console.WriteLine("No Data Found!");
        }
        else
        {
            Console.WriteLine("details of person is");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("id of the person is:" + position.Id);
            Console.WriteLine("Name of the person is: " + position.Name);
            Console.WriteLine("Age of the person is:" + position.Age);
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
                Id = newId++,
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
        int target = list.Count + 1;
        Person position = null;
        Console.WriteLine(
            "Enter the ID of the person to delete or Type " + target + " to see the list..."
        );
        int SearchId = Convert.ToInt32(Console.ReadLine());
        if (SearchId == target)
        {
            Display();
        }
        foreach (var item in list)
        {
            if (item.Id == SearchId)
                position = item;
        }
        if (position != null)
        {
            list.Remove(position);
            Console.WriteLine("Item at ID:" + " " + position.Id + " " + "successfully deleted");
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
        Person position =null;
        foreach (var item in list)
        {
            if (item.Id == SearchId)
            {
                position = item;
                break;
            }
        }
         if(position == null){
                Console.WriteLine("Item not found");
                return;
         }
        Console.WriteLine("Enter new Name:");
        NewName = Console.ReadLine();
        Console.WriteLine("Enter new Age:");
        NewAge = Convert.ToInt32(Console.ReadLine());
        position.Name = NewName;
        position.Age = NewAge;
        Console.WriteLine("Item at ID:" + position + "successfully Updated");
        Display();
    }

    public void Search()
    {
        int SearchId = 0;
        string SearchName = "";
        Person position = null;
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
                   position = item;
                    break;
                }
            }
            if(position == null){
                Console.WriteLine("ID not found");
                return;
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
                   position = item;
                    break;
                }
            }
        }
        else{
            Console.WriteLine("Wrong Input");
            return;
        }
                    Display(position);

    }
}
