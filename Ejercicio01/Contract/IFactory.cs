using Ejercicio01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.Contract
{
    public interface IFactory
    {
        public void CreateCar(string idPlate, string color, int numberDoors, int price, int model);
        public Car SellCarSelectCustomer(Customer customer, string color, int model);

        public int SizeCarStore();
        public void SeeCarAll();
    }
}
