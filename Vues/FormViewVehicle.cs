using Data;
using Entities;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vues
{
    public static class FormViewVehicle
    {
        public static void ByNumber(DataVehicle dataVehicle)
        {
            /* Summary: Request to enter a vehicle number in the console. 
             * If it exists the vehicle is displayed with the method 'ShowVehicle.column(vh);'.
             * 
             * */
            if (dataVehicle.Vehicles.Count == 0)
            {
                Console.WriteLine("La liste de vehicule est vide.");
                return;
            }

            var number = InputRules.GetExistVehicleNumberFromConsole(dataVehicle);
            var vh = dataVehicle.Vehicles.FirstOrDefault(v => v.Number == number);
            if (vh == null)
                return;
            else
                ShowVehicle.Column(vh);
        }
    }
}
