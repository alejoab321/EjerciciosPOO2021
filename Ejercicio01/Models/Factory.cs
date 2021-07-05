using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void CreateCar(Car car) 
        {
            if (AbilityCreateCar >= Cars.Count )
            {
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

    }
}
