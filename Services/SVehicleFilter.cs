using Data;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class SVehicleFilter
    {
        public static void FilterBy(string filter, DataVehicle dataVehicle)
        {
            switch (filter)
            {
                case "MA": // Filter by Brand
                    Console.WriteLine("Liste filtrée par marque.");
                    var input1 = InputRules.GetVehicleBrandFromConsole("Marque :");
                    var newList1 = dataVehicle.Vehicles.Where(x => (x.Brand.ToUpper()) == (input1.ToUpper())).ToList();
                    Vues.ShowList.Vehicle(newList1);
                    break;
                case "MO": // Filter by model
                    var input2 = Helpers.GetStringFromConsole("Modèle :", "", s => s.Length > 0);
                    var newList2 = dataVehicle.Vehicles.Where(x => (x.Model.ToUpper()) == (input2.ToUpper())).ToList();
                    Vues.ShowList.Vehicle(newList2);
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
