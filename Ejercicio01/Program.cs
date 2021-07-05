using Ejercicio01.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory(10)
            {
                Cars = new List<Car>(),
                Mark = "Chevrolet",
                TotalSales = 0
            };
            Car car1 = new Car()
            {
                Color = "Blue",
                Price = 5000,
                IdPlate = "KWH-125",
                NumberDoors = 4,
                Model = 2020,
                Mark = "Chevrolet"
            };

            Car car2 = new Car()
            {
                Color = "Blue",
                Price = 4000,
                IdPlate = "KWH-155",
                NumberDoors = 4,
                Model = 2018,
                Mark = "Chevrolet"
            };

            factory.CreateCar(car1);
            factory.CreateCar(car2);

            factory.SeeCarAll();

            //Car car1 = new Car("Red",2015,"Mazda");

            //Console.WriteLine(car1);
            //car1.SpeedUp();
            //Console.WriteLine(car1);
            //car1.BrakeCar();
            //Console.WriteLine(car1);
            Console.Read();
        }
    }
}
