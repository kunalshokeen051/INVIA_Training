using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.SqlServer.Server;
using P1.Models;


namespace P1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<data> students = new List<data>
        {
            new data { Id = 1, FName = "Kunal", LName = "Shokeen", Course = "MVC", City = "Gurgaon", Phone = "555-1234" },
            new data { Id = 2, FName = "Pankaj", LName = "Negi", Course = "ASP.NET", City = "Noida", Phone = "555-5678" },
            new data { Id = 3, FName = "Nilanshu", LName = "Yadav", Course = "C#", City = "Hapur", Phone = "555-7890" },
            new data { Id = 4, FName = "Amit", LName = "Kumar", Course = "Java", City = "Delhi", Phone = "555-4321" },
            new data { Id = 5, FName = "Sneha", LName = "Verma", Course = "Python", City = "Mumbai", Phone = "555-8765" },
            new data { Id = 6, FName = "Rajesh", LName = "Singh", Course = "Web Development", City = "Bangalore", Phone = "555-9876" },
            new data { Id = 7, FName = "Priya", LName = "Sharma", Course = "Data Science", City = "Chennai", Phone = "555-2345" },
            new data { Id = 8, FName = "Anita", LName = "Gupta", Course = "AI", City = "Kolkata", Phone = "555-6789" },
            new data { Id = 9, FName = "Amit", LName = "Patel", Course = "Machine Learning", City = "Mumbai", Phone = "555-1234" },
            new data { Id = 10, FName = "Sara", LName = "Kumar", Course = "Cybersecurity", City = "Delhi", Phone = "555-5678" },
            new data { Id = 11, FName = "Rahul", LName = "Verma", Course = "Software Engineering", City = "Pune", Phone = "555-4321" },
            new data { Id = 12, FName = "Neha", LName = "Rajput", Course = "Database Management", City = "Hyderabad", Phone = "555-8765" },
            new data { Id = 13, FName = "Arun", LName = "Thakur", Course = "Mobile App Development", City = "Jaipur", Phone = "555-9876" },
            new data { Id = 14, FName = "Pooja", LName = "Mishra", Course = "Cloud Computing", City = "Lucknow", Phone = "555-2345" },
            new data { Id = 15, FName = "Sanjay", LName = "Yadav", Course = "Data Analytics", City = "Ahmedabad", Phone = "555-6789" },
            new data { Id = 16, FName = "Alisha", LName = "Singhania", Course = "Frontend Development", City = "Bengaluru", Phone = "555-3456" },
            new data { Id = 17, FName = "Vikram", LName = "Malhotra", Course = "Backend Development", City = "Chandigarh", Phone = "555-7890" },
            new data { Id = 18, FName = "Kavita", LName = "Gandhi", Course = "Artificial Intelligence", City = "Kochi", Phone = "555-6543" },
            new data { Id = 19, FName = "Raj", LName = "Kapoor", Course = "Data Science", City = "Chennai", Phone = "555-1234" },
            new data { Id = 20, FName = "Nisha", LName = "Sharma", Course = "Web Development", City = "Mysore", Phone = "555-5678" },
            new data { Id = 21, FName = "Rakesh", LName = "Verma", Course = "Machine Learning", City = "Puducherry", Phone = "555-4321" },
            new data { Id = 22, FName = "Simran", LName = "Reddy", Course = "Software Engineering", City = "Visakhapatnam", Phone = "555-8765" },
            new data { Id = 23, FName = "Rajat", LName = "Gupta", Course = "AI", City = "Kolkata", Phone = "555-9876" }
        };

            ViewBag.Students = students;
            return View();
        }
    }
}