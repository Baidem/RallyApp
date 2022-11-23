using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Truck : Vehicle
    {
        private int? _weight;
        public int? Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public Truck()
        {
        }
        public Truck(int number) : base(number)
        {
        }
        public Truck(int number, string brand, string model, int weight) : base(number, brand, model)
        {
            Weight = weight;
        }
        public void truck()
        {
            Console.WriteLine("Pimp my truck");
        }
        public override string ToString()
        {
            return $" Camion Numéro: {Number} Marque: {Brand} Modèle: {Model} Poids: {Weight}";
        }
        public override void ToStringColomn()
        {
            Console.WriteLine($" _____________________");
            Console.WriteLine($"|       Camion        |");
            Console.WriteLine($"|---------------------|");
            Console.WriteLine($"|   Numéro : {Number}");
            Console.WriteLine($"|   Marque : {Brand}");
            Console.WriteLine($"|    Model : {Model}");
            Console.WriteLine($"|    Poids : {Weight}");
            Console.WriteLine($" ---------------------");

        }
    }
}