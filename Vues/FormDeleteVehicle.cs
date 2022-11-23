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
    public static class FormDeleteVehicle
    {
        public static Vehicle? ByNumber(DataVehicle dataVehicle)
        {
            if (dataVehicle.Vehicles.Count == 0)
                return null;

            Console.WriteLine("Supprimer un véhicule");
            var number = InputRules.GetExistVehicleNumberFromConsole(dataVehicle);
            var vh = dataVehicle.Vehicles.FirstOrDefault(v => v.Number == number);
            if (vh == null)
            {
                Console.WriteLine("Pas de véhicule avec ce numéro");
                return null;
            }
            else
            {
                ShowVehicle.Column(vh);
                Console.WriteLine("Saisir 'OUI' pour confirmer la suppression de ce véhicule :");
                var res = Helpers.GetStringFromConsole("", "", s => s.Length > 0).ToUpper();
                if (res == "OUI")
                {
                    Console.WriteLine("Supprimé");
                    return vh;
                }
                Console.WriteLine("Annulé");
                return null;
            }
        }

    }
}
