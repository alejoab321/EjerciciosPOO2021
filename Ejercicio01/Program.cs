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
            

            

            for (int i = 0; i < factory.AbilityCreateCar + 1; i++)
            {

                factory.CreateCar(idPlate: "ACH-728", color: "Blue", numberDoors: 4, price: 2000, model: 2018);
            }
            factory.SeeCarAll();

            Customer carlos = new Customer()
            {
                Cash = 2900,
                IdClient = "10456984123",
                Name = "Carlos"
            };

            factory.SellCarSelectCustomer(carlos,"Blue",2018);

            factory.SeeCarAll();

            foreach (var car in carlos.Cars)
            {
                Console.WriteLine("Carro = {0}",car);
            }
            Console.WriteLine("Cash = {0}", carlos.Cash);
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
