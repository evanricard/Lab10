using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class UsedCar : Car
    {
        double mileage;

        public UsedCar()
        {

        }

        public UsedCar(int carlot, string make, string model, int year, double price, double mileage) : base(carlot, make, model, year, price)
        {
            this.mileage = mileage;
        }

        public double Mileage { get => mileage; set => mileage = value; }

        public override string ToString()
        {
            return base.ToString() + $"\tMileage: {(mileage),10:n}" + " - Used Car";
        }

    }
}
