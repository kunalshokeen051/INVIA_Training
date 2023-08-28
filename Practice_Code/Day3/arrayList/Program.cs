using System;
using System.Collections.Generic;

class Person
{
    public string Name;
    public int Age;
    public int Id;
}

class Functions
{
    int search = 0;
    List<Person> list = new List<Person>();

    public void Display()
    {
        if (list.Count == 0)
        {
            list.Add(new Person{
            Id= 0,
            Name= "Rahul1",
            Age= 21,
            });
            list.Add(new Person{
            Id= 1,
            Name= "Rahul2",
            Age= 22,
            });
            list.Add(new Person{
            Id= 2,
            Name= "Rahul3",
            Age= 23,
            });
            Display();
        }
        else {
         Console.WriteLine("List is");
            foreach (Person p in list)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("id of the person is:" + p.Id);
                Console.WriteLine("Name of the person is: " + p.Name);
                Console.WriteLine("Age of the person is:" +p.Age);
            }
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
                Id = list.Count(),
                Name = AddName,
                Age = AddAge
            }
        );
        Console.WriteLine("Item was successfully added");
        Display();
    }
    public void Delete()
    {
        Console.WriteLine("Enter the Id of the person to delete");
        int SearchId = Convert.ToInt32(Console.ReadLine());
        var position = 0;
        foreach (var item in list)
        {
            if( item.Id == SearchId)
            position = item.Id;

            else
            Console.WriteLine("Item not found");
        }
        list.RemoveAt(position);
        Console.WriteLine("Item at" + "ID:" + position + "successfully deleted");
        Display();
    }
}

class InitialClass
{
    public static void Main()
    {
        Functions obj = new Functions();
        Console.WriteLine("1. Display List  2. Add an item  3. Delete an Item  4. Modify an Item");
        Console.WriteLine("Enter Your Choice: ");
        int Index = Convert.ToInt16(Console.ReadLine()); 
        switch (Index)
        {
            case 0:
                return;
            case 1:
            {
                Console.WriteLine("DISPLAY lIST SELECTED");
                obj.Display();
                break;
            }
            case 2:
            {
                Console.WriteLine("ADDITION TO LIST SELECTED");
                obj.Add();
                break;  
            }
            case 3:
                Console.WriteLine("DELETE OPTION SELECTED");
                OBJ.Delete();
                break;
            case 4:
                Console.WriteLine("MODIFICATION OF LIST ITEMS SELECTED");
                break;
            default:
                Console.WriteLine("Wrong Input Entered, Please Try Again");
                break;
        }
        Console.ReadLine();
    }
}
