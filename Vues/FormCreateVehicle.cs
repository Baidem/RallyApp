using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;
using Logic;

namespace Vues
{
    public static class FormCreateVehicle
    {
        /* TO DO :
         * Factorisation des méthodes ReadCar() et ReadTruck()
         * */
        public static Vehicle Display(DataVehicle dataVehicle)
        {
            string q = "";
            Vehicle vh = new();
            while (!(q is "V" or "C"))
                q = Helpers.GetStringFromConsole("V: Voiture ou C: Camion", "", s => s.Length > 0).ToUpper();

            if (q == "V")
                vh = ReadCar(dataVehicle);
            else if (q == "C")
                vh = ReadTruck(dataVehicle);

            return vh;
        }
        public static Car ReadCar(DataVehicle dataVehicle)
        {
            int? _number = null;
            int number;
            while (_number == null)
                _number = InputRules.GetNewVehicleNumberFromConsole(dataVehicle);
            number = _number.Value;

            string? brand = null;
            while (brand == null)
                brand = InputRules.GetVehicleBrandFromConsole("Nouvelle marque de la voiture");

            var model = Helpers.GetStringFromConsole("Modèle de la voiture : ", "", s => s.Length > 1);
            var power = Helpers.GetIntFromConsole("Puissance de la voiture : ", "n => n > 0", n => n > 0);
            return new Car(number, brand, model, power);
        }

        public static Truck ReadTruck(DataVehicle dataVehicle)
        {
            int? _number = null;
            int number;
            while (_number == null)
                _number = InputRules.GetNewVehicleNumberFromConsole(dataVehicle);
            number = _number.Value;

            string? brand = null;
            while (brand == null)
                brand = InputRules.GetVehicleBrandFromConsole("Nouvelle marque du camion");

            var model = Helpers.GetStringFromConsole("Modèle du camion : ", "", s => s.Length > 1);
            var weigth = Helpers.GetIntFromConsole("Poids du camion : ", "n => n > 0", n => n > 0);

            return new Truck(number, brand, model, weigth);
        }



    }
}
