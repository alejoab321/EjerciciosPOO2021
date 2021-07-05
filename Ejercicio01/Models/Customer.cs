using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.Models
{
    public class Customer
    {
        public string IdClient { get; set; }
        public string Name { get; set; }
        public double Cash { get; set; }
        public List<Car> Cars { get; set; }

        public Customer()
        {
            Cars = new List<Car>();
        }
    }
}
