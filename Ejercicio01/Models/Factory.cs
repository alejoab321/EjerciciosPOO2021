using System;
using System.Collections.Generic;


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

        private void SeeCarAll(double Cash)
        {
            int count = 0;
            foreach (var car in Cars)
            {
                if (Cash >= car.Price)
                {
                    Console.WriteLine(car);
                    count++;
                }
                
            }
            Console.WriteLine(count == 0 ? "No tienes suficientes fondos, por favor ahorra" : $"Tienes la capacidad para comprar un carro estás a solo un paso!!!!");
        }

        public void SellCar(Customer customer)
        {
            SeeCarAll(customer.Cash);
        }

    }
}
