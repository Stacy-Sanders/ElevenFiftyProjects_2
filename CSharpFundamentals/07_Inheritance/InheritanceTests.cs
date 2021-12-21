using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_Inheritance
{
    [TestClass]
    public class InheritanceTests
    {
        [TestMethod]
        public void PersonExamples()
        {
            // var person = new Person();
            // person.FirstName = "Stacy";
            // person.ToString();

            var customer = new Customer(true, "Stacy", "Sanders", "8125555555", "stacy.sanders@orbeez.com");
            customer.ToString();
            customer.FirstName = "Lawrence";
            customer.IsPremium = true;

            var employee = new Employee();
            employee.FirstName = "Luke";
            employee.HireDate = DateTime.Today;

            var hourlyEmployee = new HourlyEmployee();


            List<Person> people = new List<Person>();
            // people.Add(person);
            people.Add(customer);
            people.Add(employee);
            people.Add(hourlyEmployee);
           
        }
    }
}
