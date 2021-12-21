using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _08_Interfaces
{
    public interface IFruit
    {
        string Name { get; }        // Property with only a Get
        bool Peeled { get; set; }   // Property with a Get and a Set
        string Peel();              // Method with only a return type and no parameters
    }

    public class Banana : IFruit
    {
        public string Name
        {
            get { return "Banana"; }
        }
        public bool Peeled { get; set; }

        public string Peel()
        {
            Peeled = true;
            return "You peel the banana.";
        }
    }

    public class Orange : IFruit
    {
        public string Name
        {
            get
            {
                return "Orange";
            }
        }
        public bool Peeled { get; set; }

        public string Peel()
        {
            Peeled = true;
            return "You peel the orange.";
        }

        public string Squeeze()
        {
            return "You squeeze the orange and juice comes out";
        }
    }

    public class Grape : IFruit
    {
        public string Name
        {
            get { return "Grape"; }
        }


        public bool Peeled { get; set; }

        public string Peel()
        {
            return "Who peels grapes?";
        }
    }

    [TestClass]
    public class IntroductionToInterfaces
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            // New up an instance of an IFruit
            IFruit fruit = new Orange();

            string output = fruit.Peel();
            Console.WriteLine(output);

            Console.WriteLine($"The {fruit.Name} is peeled: " + fruit.Peeled);
        }

        [TestMethod]
        public void InterfacesInCollections()
        {
            var orange = new Orange();

            var fruitSalad = new List<IFruit>();
            fruitSalad.Add(orange);
            fruitSalad.Add(new Banana());
            fruitSalad.Add(new Grape());

            foreach (var fruit in fruitSalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());
            }

            Console.WriteLine(orange.Squeeze());
        }

        private string GetFruitName(IFruit fruit)
        {
            return $"This fruit is called {fruit.Name}";
        }

        [TestMethod]
        public void InterfacesInMethods()
        {
            var fruit = new Orange();

            var output = GetFruitName(fruit);

            Console.WriteLine(output);

        }
    }
}




