using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Logic
{
    public static class InputRules
    {
        public static bool IsVehicleNumberValid(int n)
        {
            if (n >= 1000 && n <= 999999)
                return true;

            Console.WriteLine("Saisie invalide : 999 < N < 1000000 !");
            return false;
        }
        public static int? GetNewVehicleNumberFromConsole(DataVehicle dataVehicle)
        {
            var numbers = dataVehicle.Vehicles.Select(x => x.Number);
            int nb = Helpers.GetIntFromConsole("Saisir un nouveau numéro de véhicule : ", "", InputRules.IsVehicleNumberValid);
            if (numbers.Any(n => n == nb))
            {
                Console.WriteLine("Numéro déjà existant.");
                return null;
            }
            Console.WriteLine($"Nouveau Numéro : {nb}");
            return nb;
        }
        public static int? GetExistVehicleNumberFromConsole(DataVehicle dataVehicle)
        {
            var isExiste = false;
            int nb = 0;
            var numbers = dataVehicle.Vehicles.Select(x => x.Number);
            nb = Helpers.GetIntFromConsole("Saisir un numéro de véhicule existant : ", "", InputRules.IsVehicleNumberValid);
            isExiste = numbers.Any(n => n == nb);
            if (!isExiste)
            {
                Console.WriteLine("Ce numéro de voiture n'existe pas.");
                return null;
            }
            return nb;
        }
        public static string? GetVehicleBrandFromConsole(String label)
        {
            Console.WriteLine(label);
            var brand = Helpers.GetStringFromConsole("Marque de la voiture : ", "", s => s.Length > 0);
            foreach (var b in brand)
            {
                string sans = "0123456789";
                foreach (var s in sans)
                {
                    if (b == s)
                    {
                        Console.WriteLine("Chiffre non-autorisé.");
                        return null;
                    }
                }
            }
            return brand;
        }


    }
}
