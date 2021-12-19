using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void CookieTests()
        {
            Cookie cookie = new Cookie(); // New instance of Cookie - new Cookie type
            cookie.Name = "Snickerdoodle";
            cookie.HasNuts = false;

            Cookie anotherCookie = new Cookie(); // allowed due to blank constructor
            anotherCookie.Name = "Something else";
            anotherCookie.GramsOfFlour = 10;

            Cookie snickerdoodle = new Cookie("Snickerdoodle", false, 11.5); // constructor from classes filled out
            Cookie newCookie = new Cookie("Peanut Butter", true, 150);
        }


        [TestMethod]
        public void VehicleTests()
        {
            Vehicle car = new Vehicle();
            car.TypeOfVehicle = VehicleType.Car;

            Vehicle newCAr = new Vehicle
            {
                TypeOfVehicle = VehicleType.Car,
                Make = "Honda",
                Model = "Civic"
            };

        }
    }
}


