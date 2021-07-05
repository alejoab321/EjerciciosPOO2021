using Ejercicio01.Contract;
using Ejercicio01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.Factory
{
    public class FactoryChevrolet : IFactory
    {
        public void CreateCar(string idPlate, string color, int numberDoors, int price, int model)
        {
            throw new NotImplementedException();
        }

        public void SeeCarAll()
        {
            throw new NotImplementedException();
        }

        public Car SellCarSelectCustomer(Customer customer, string color, int model)
        {
            throw new NotImplementedException();
        }

        public int SizeCarStore()
        {
            throw new NotImplementedException();
        }
    }
}
