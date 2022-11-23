using Data;
using Entities;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class SVehicleSort
    {
        public static void SortBy(string sort, DataVehicle dataVehicle)
        {
            switch (sort)
            {
                case "NU": // Sort by Number
                    Console.WriteLine("Liste triée par numéro.");
                    var newList1 = dataVehicle.Vehicles.OrderBy(x => x.Number).ToList();
                    dataVehicle.Vehicles = newList1;
                    Vues.ShowList.Vehicle(dataVehicle.Vehicles);
                    break;
                case "MA": // Sort by Brand
                    Console.WriteLine("Liste triée par marque.");
                    var newList2 = dataVehicle.Vehicles.OrderBy(x => x.Brand).ToList();
                    dataVehicle.Vehicles = newList2;
                    Vues.ShowList.Vehicle(dataVehicle.Vehicles);
                    break;
                case "MO": // Sort by model
                    Console.WriteLine("Liste triée par model.");
                    var newList3 = dataVehicle.Vehicles.OrderBy(x => x.Model).ToList();
                    dataVehicle.Vehicles = newList3;
                    Vues.ShowList.Vehicle(dataVehicle.Vehicles);
                    break;
                case "AN": // Cancel
                    Console.WriteLine("Annulé");
                    break;
                default:
                    break;
            }
        }
    }
}
