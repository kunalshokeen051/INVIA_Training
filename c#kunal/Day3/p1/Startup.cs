using System;
using System.Collections.Generic;
using Day3.Models;
using Day3.Service;

namespace Day3
{
    public class Startup
    {
        public static void Main()
        {
            PersonDetails obj = new PersonDetails();
            obj.AddPerson();
            var temp = obj.DisplayPerson();
            foreach (var item in temp)
            {
                Console.WriteLine(item.Name + item.qual);
            }
        }
    }
}
