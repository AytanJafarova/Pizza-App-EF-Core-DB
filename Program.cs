using PizzaAppManagement.Data;
using PizzaAppManagement.Models;
using System;


class TestClass
{
    static void Main(string[] args)
    {
        PizzaDbContext pizzaDbContext = new PizzaDbContext();
        foreach (Customer c in pizzaDbContext.Customers) 
        {
            Console.WriteLine($"Name: {c.FirstLast}");
        }
    }
}