using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio01.Models
{
    public class Factory
    {
        
        public List<Car> Cars { get; set; }
        public string Mark { get; set; }
        public double TotalSales { get; set; }
        public readonly int AbilityCreateCar;

        public Factory(int abilityCreateCar)
        {
            AbilityCreateCar = abilityCreateCar;
        }

        public void CreateCar(string idPlate, string color, int numberDoors, int price, int model) 
        {
            
            if (AbilityCreateCar > Cars.Count )
            {
                Car car = new Car(idPlate,color,numberDoors,price, Mark, model);

                Cars.Add(car);
                Console.WriteLine("El carro se creó satisfactoriamente");
            }
            else
            {
                Console.WriteLine("El carro no se pudo crear porque superó la capacidad de producción");
            }
            
        }

        public void SeeCarAll()
        {
            foreach (var car in Cars)
            {
                Console.WriteLine(car);
            }
        }

        private List<Car> SeeCarAll(double Cash)
        {
            int count = 0;
            List<Car> carFilterBuyCustomer = new List<Car>();
            foreach (var car in Cars)
            {
                if (Cash >= car.Price)
                {
                    Console.WriteLine(car);
                    count++;
                    carFilterBuyCustomer.Add(car);
                }
                
            }
            //Console.WriteLine(count == 0 ? "No tienes suficientes fondos, por favor ahorra" : $"Tienes la capacidad para comprar un carro estás a solo un paso!!!!");
            return carFilterBuyCustomer;
        }

        private Car SellCar(Customer customer, string color, int model)
        {
            var selectCarBuy = SeeCarAll(customer.Cash);
            if (selectCarBuy.Any())
            {
                Car carBuy = selectCarBuy.Find(x => x.Color == color && x.Model == model);
                return carBuy;
            }
            return null;
            

        }

        public Car SellCarSelectCustomer(Customer customer, string color, int model)
        {
            Car car = SellCar(customer, color, model);
            customer.Cash -= car.Price;
            customer.Cars.Add(car);
            TotalSales += car.Price;
            Cars.Remove(car);
            return car;
        }

    }
}
