using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.Models
{
    public class Car
    {
        public string IdPlate { get; set; }
        public string Color { get; set; }
        public double Speed { get; private set; }
        public int NumberDoors { get; set; }
        public int Price { get; set; }
        public string Mark { get; set; }
        public int Model { get; set; }
        public double SpeedUp()
        {
            Speed = Speed + 10;
            return Speed;
        }
        public double BrakeCar()
        {
            Speed = Speed - 10;
            return Speed;
        }

        public Car()
        {

        }

        public Car(string color, int model, string mark)
        {
            Color = color;
            Model = model;
            Mark = mark;
        }

        public Car(string idPlate, string color, int numberDoors, int price, string mark, int model)
        {
            IdPlate = idPlate;
            Color = color;
            NumberDoors = numberDoors;
            Price = price;
            Mark = mark;
            Model = model;
        }

        public override string ToString()
        {
            return $"Mark = {Mark} \n IdPlate = {IdPlate} \n Color = {Color} \n Speed = {Speed}";
        }

    }
}
