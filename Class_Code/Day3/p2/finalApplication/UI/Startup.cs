using System;
using System.Collections.Generic;
using Models;
using Service;

namespace UI;
    public class Startup
    {
         public static void Main()
        {
            PersonDetails obj = new PersonDetails();
            obj.AddPerson();
            var temp = obj.DisplayPerson();
                Console.WriteLine("");
            Console.WriteLine("------ List Items --------");
                Console.WriteLine("");
            foreach (var item in temp)
            {
                Console.WriteLine("Name:" + " " + item.Name);
                Console.WriteLine("Qualification:" + " " +item.qual);
                Console.WriteLine("");
            }
        }
    }