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
    public static class FormUpdateVehicle
    {
        public static void ByNumber(DataVehicle dataVehicle)
        {
            /* Summary: Choice of the vehicle to modify by its number. 
             * Confirmation of the modifications. 
             * Modification of the properties of the Vehicle by these 'Setters'.
             * TO DO : DRY
             * */
            if (dataVehicle.Vehicles.Count == 0)
            {
                Console.WriteLine("La liste de vehicule est vide.");
                return;
            }

            // Which vehicle number do we want to change? Is it valid? Does it exist (If it does not exist: return)?
            var number = InputRules.GetExistVehicleNumberFromConsole(dataVehicle);
            if (number == null)
                return;

            // the vehicle
            var vh = dataVehicle.Vehicles.FirstOrDefault(v => v.Number == number);
            //
            var nu = vh.Number;
            var br = vh.Brand;
            var mo = vh.Model;
            int? po = (vh is Car) ? ((Car)vh).Power : null;
            int? we = (vh is Truck) ? ((Truck)vh).Weight : null;
            //
            var isCancel = false;
            var isOk = false;
            //
            while (isCancel == false && isOk == false)
            {
                if (vh is Car)
                    Console.WriteLine($"Voiture sélectionnée = Numéro : {nu}, Marque : {br}, Modèle : {mo}, Puissance : {po}");
                else if (vh is Car)
                    Console.WriteLine($"Camion sélectionné = Numéro : {nu}, Marque : {br}, Modèle : {mo}, Poids : {we}");
                else
                    Console.WriteLine("Véhicule illégal");

                Console.WriteLine("Pour modifier saisir :");
                Console.WriteLine("NU : Numéro, 'MA' : Marque, 'MO' : Modèle, 'PU' : Puissance (voiture), 'PO' : Poids (camion)");
                Console.WriteLine("'AN' : Pour tout annuler");
                Console.WriteLine("'OK' : Pour enregistrer les modifications");
                string switch_on = Helpers.GetStringFromConsole("Valeur ?", "", s => s.Length > 0).ToUpper();
                switch (switch_on)
                {
                    case "NU": // Modify the Number
                        int? _nu = null;
                        _nu = InputRules.GetNewVehicleNumberFromConsole(dataVehicle);
                        if (_nu == null)
                            break;
                        nu = _nu.Value;
                        break;
                    case "MA": // Modify the Brand
                        br = InputRules.GetVehicleBrandFromConsole("Nouvelle Marque");
                        break;
                    case "MO": // Modify the model
                        mo = Helpers.GetStringFromConsole("Nouveau modèle : ", "", s => s.Length > 0);
                        break;
                    case "PU": // Modify the power
                        if (vh is Car)
                            po = Helpers.GetIntFromConsole("Nouvelle puissance : ", "n => n > 0", n => n > 0);
                        else
                            Console.WriteLine("saisie impossible");
                        break;
                    case "PO": // Change the Weight
                        if (vh is Truck)
                            we = Helpers.GetIntFromConsole("Nouveau poids : ", "n => n > 0", n => n > 0);
                        else
                            Console.WriteLine("saisie impossible");
                        break;
                    case "AN": // Cancel
                        Console.WriteLine("Modification annulée");
                        isCancel = true;
                        isOk = false;
                        break;
                    case "OK": // Save modifications
                        Console.WriteLine("Enregistrement des modifications ?");
                        isOk = true;
                        isCancel = false;
                        break;
                    default:
                        Console.WriteLine("Mauvaise saisie");
                        isCancel = true;
                        isOk = false;
                        break;
                }
            }
            if (!isCancel && isOk)
            {
                var confirm = Helpers.GetStringFromConsole("Saisir 'OUI' pour confirmer l'enregistrement / 'N' pour annuler", "", s => s.Length > 0).ToUpper();
                if (confirm == "OUI")
                {
                    vh.Number = nu;
                    vh.Brand = br;
                    vh.Model = mo;
                    if (vh is Car)
                        ((Car)vh).Power = po;
                    else if (vh is Truck)
                        ((Truck)vh).Weight = we;

                    Console.WriteLine(vh);
                    Console.WriteLine("est modifié.");
                }
                else
                    Console.WriteLine("Les modifications ont étés annulées");//DRY!!
            }
            else
                Console.WriteLine("Les modifications ont étés annulées");//DRY!!
        }
    }
}
