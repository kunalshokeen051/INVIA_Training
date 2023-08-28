using System;
using System.Collections.Generic;
using Models;
using Functionality;

namespace Service
{
    public class PersonDetails : IPersonDetails
    {
        public List<Person> personList = new List<Person>();
        private int newId = 1;

        public PersonDetails()
        {
            InitializeDefaultData();
        }

        private void InitializeDefaultData()
        {
            personList.Add(new Person { Id = 1, Name = "Kunal Shokeen", Age = 23 });
            personList.Add(new Person { Id = 2, Name = "Pankaj Negi", Age = 24 });
            personList.Add(new Person { Id = 3, Name = "Nilanshu", Age = 22 });
        }

        public void Display()
        {
            if (personList.Count == 0)
            {
                Console.WriteLine("No Data Found!");
            }
            else
            {
                Console.WriteLine("List is");
                foreach (Person person in personList)
                {
                    Console.WriteLine($"id of the person is: {person.Id}");
                    Console.WriteLine($"Name of the person is: {person.Name}");
                    Console.WriteLine($"Age of the person is: {person.Age}\n");
                }
            }
        }
        public void Display(Person person)
        {
            if (personList.Count == 0)
            {
                Console.WriteLine("No Data Found!");
            }
            else
            {
                Console.WriteLine($"id of the person is: {person.Id}");
                Console.WriteLine($"Name of the person is: {person.Name}");
                Console.WriteLine($"Age of the person is: {person.Age}\n");
            }
        }

        public void Add()
        {
            Console.WriteLine("Enter the name of the person");
            string addName = Console.ReadLine();
            Console.WriteLine("Enter the Age of the person");
            int addAge = Convert.ToInt32(Console.ReadLine());
            personList.Add(new Person { Id = newId++, Name = addName.ToLower(), Age = addAge });
            Console.WriteLine("\nItem was successfully added\n");
            Display();
        }

        public void Delete()
        {
            Console.WriteLine("Enter the ID of the person to delete:");
            int searchId = Convert.ToInt32(Console.ReadLine());

            Person personToDelete = personList.Find(p => p.Id == searchId);
            if (personToDelete != null)
            {
                personList.Remove(personToDelete);
                Console.WriteLine($"Item at ID {personToDelete.Id} successfully deleted");
                Display();
            }
            else
            {
                Console.WriteLine("Item not found");
            }
        }

        public void Modify()
        {
            Console.WriteLine("Enter the Id of the person to modify:");
            int searchId = Convert.ToInt32(Console.ReadLine());
            Person personToModify = personList.Find(p => p.Id == searchId);

            if (personToModify != null)
            {
                Console.WriteLine("Enter new Name:");
                string newName = Console.ReadLine();
                Console.WriteLine("Enter new Age:");
                int newAge = Convert.ToInt32(Console.ReadLine());

                personToModify.Name = newName;
                personToModify.Age = newAge;
                Console.WriteLine($"Item at ID {personToModify.Id} successfully Updated");
                Display();
            }
            else
            {
                Console.WriteLine("Item not found");
            }
        }
        public void Search()
        {
            Console.WriteLine("1. Search by ID");
            Console.WriteLine("2. Search by Name");
            Console.WriteLine("\nEnter an option:");
            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("Enter ID:");
                int searchId = Convert.ToInt32(Console.ReadLine());
                Person foundPerson = personList.Find(p => p.Id == searchId);

                if (foundPerson != null)
                {
                    Display(foundPerson);
                }
                else
                {
                    Console.WriteLine("ID not found");
                }
            }
            else if (option == 2)
            {
                Console.WriteLine("Enter Name:");
                string searchName = Console.ReadLine().ToLower();
                Person foundPerson = personList.Find(p => p.Name.ToLower() == searchName);

                if (foundPerson != null)
                {
                    Display(foundPerson);
                }
                else
                {
                    Console.WriteLine("Name not found");
                }
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        }

        public void Sort()
        {
            Console.WriteLine("1. DECREMENT SORT");
            Console.WriteLine("2. INCREMENT SORT");
            Console.WriteLine("3. Return to Main Menu");
            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 1 && personList.Count > 0)
            {
                Console.WriteLine("DECREMENT SORT SELECTED");
                personList.Sort((a, b) => b.Age.CompareTo(a.Age));
                Display();
            }
            else if (option == 2 && personList.Count > 0)
            {
                Console.WriteLine("INCREMENT SORT SELECTED");
                personList.Sort((a, b) => a.Age.CompareTo(b.Age));
                Display();
            }
            else if (option == 3)
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid option or the list is empty");
            }
        }

        public void Filter()
        {
            Console.WriteLine("1. Greater than equal to");
            Console.WriteLine("2. Greater than");
            Console.WriteLine("3. Smaller than Equal to");
            Console.WriteLine("4. Smaller than");
            Console.WriteLine("Enter an option:");
            int option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Query Age:");
            int query = Convert.ToInt32(Console.ReadLine());

            var filteredList = new List<Person>();

            switch (option)
            {
                case 1:
                    filteredList = personList.Where(p => p.Age >= query).ToList();
                    break;
                case 2:
                    filteredList = personList.Where(p => p.Age > query).ToList();
                    break;
                case 3:
                    filteredList = personList.Where(p => p.Age <= query).ToList();
                    break;
                case 4:
                    filteredList = personList.Where(p => p.Age < query).ToList();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    return;
            }

            Console.WriteLine("\n----Results----\n");
            Console.WriteLine("INDEX\tITEMS\tPRICE");
            foreach (var person in filteredList)
            {
                Console.WriteLine($"{person.Id}\t{person.Name}\t{person.Age}");
            }
        }


    }
}


