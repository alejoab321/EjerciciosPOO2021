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
            List<Car> cars = new List<Car>();
            if (!cars.Any()) //! Negación : Si cars.Any() = true por negación es false, y si es false entonces es true
            {
                Console.WriteLine("La lista no tiene carros");
            }
            cars.Add(car1);
            cars.Add(car2);

            if (cars.Any())
            {
                Console.WriteLine("La lista contiene carros");
            }
            foreach (var car in cars)
            {
                if (car.Model > 2018)
                {
                    Console.WriteLine("Carros Modelos MAyores a 2018 \n {0}" ,car);
                    Console.WriteLine("==================================================");
                }
                else
                {
                    Console.WriteLine("Carros Modelos Menores a 2018 \n {0}", car);
                    Console.WriteLine("==================================================");
                }

            }

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
