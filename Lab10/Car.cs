using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Car
    {
        private string make;
        private string model;
        private int year;
        private double price;
        private int carlot;

        public Car()
        {

        }

        public Car(int carlot, string make, string model, int year, double price)
        {
            this.carlot = carlot;
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }


        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double Price { get => price; set => price = value; }


        public override string ToString()
        {
            return $"{carlot}. {make,-5} {model,-5} {year,5} - {price,10:C}";
        }

    }
}
