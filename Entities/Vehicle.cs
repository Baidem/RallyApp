using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Vehicle
    {
        private int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        private string? _brand;

        public string? Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        private string? _model;

        public string? Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public Vehicle()
        {
        }
        public Vehicle(int number)
        {
            Number = number;
        }

        public Vehicle(int number, string brand, string model)
        {
            Number = number;
            Brand = brand;
            Model = model;
        }
        public void vehicle()
        {
            Console.WriteLine("Go");
        }
        public override string ToString()
        {
            return $"Vehicle Number: {Number} Brand: {Brand} Model:{Model} ";
        }
        public virtual void ToStringColomn()
        {
            Console.WriteLine($"Numéro : {Number}");
            Console.WriteLine($"Marque : {Brand}");
            Console.WriteLine($" Model : {Model}");
        }

    }
}
