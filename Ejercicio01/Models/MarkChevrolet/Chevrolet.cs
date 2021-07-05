using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.Models.MarkChevrolet
{
    public class Chevrolet : Car
    {
        public Chevrolet(string idPlate, string color, int numberDoors, int price, string mark, int model) : base(idPlate, color, numberDoors, price, mark, model)
        {
        }
    }
}
