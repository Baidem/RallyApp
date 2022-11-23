using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Car : Vehicle
    {
        private int? _power;

        public int? Power
        {
            get { return _power; }
            set { _power = value; }
        }

        public Car()
        {
        }
        public Car(int number) : base(number)
        {
        }
        public Car(int number, string brand, string model, int power) : base(number, brand, model)
        {
            Power = power;
        }

        public void car()
        {
            Console.WriteLine("Pimp my car");
        }
        public override string ToString()
        {
            return $"Voiture Numéro: {Number} Marque: {Brand} Modèle: {Model} Puissance: {Power}";
        }
        public override void ToStringColomn()
        {
            Console.WriteLine($" _____________________");
            Console.WriteLine($"|       Voiture       |");
            Console.WriteLine($"|---------------------|");
            Console.WriteLine($"|   Numéro : {Number}");
            Console.WriteLine($"|   Marque : {Brand}");
            Console.WriteLine($"|    Model : {Model}");
            Console.WriteLine($"|Puissance : {Power}");
            Console.WriteLine($" ---------------------");

        }

    }
}
