using Entities;
using Vues;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Runtime.CompilerServices;

namespace Services
{
    public static class SMenu
    {
        public static void Action(string choice, DataVehicle dataVehicle)
        {
            choice = choice.ToUpper();
            switch (choice)
            {
                case "0": // Afficher la liste de vehicule
                    ShowList.Vehicle(dataVehicle.Vehicles);
                    break;
                case "1": // Créer un vehicule
                    var vh = FormCreateVehicle.Display(dataVehicle);
                    SVehicleCreate.VehicleCreate(vh, dataVehicle);
                    break;
                case "2": // Voir un vehicule
                    FormViewVehicle.ByNumber(dataVehicle);
                    break;
                case "3": // Mettre à jour un vehicule
                    FormUpdateVehicle.ByNumber(dataVehicle);
                    break;
                case "4": // Supprimer un vehicule
                    var res = FormDeleteVehicle.ByNumber(dataVehicle);
                    SVehicleDelete.ByVehicle(res, dataVehicle);
                    break;
                case "5": // Trier les vehicules
                    var sort = FormSortVehicle.MenuSort();
                    Services.SVehicleSort.SortBy(sort, dataVehicle);
                    break;
                case "6": // Filtrer les vehicules
                    var filter = FormFilterVehicle.MenuFilter();
                    Services.SVehicleFilter.FilterBy(filter, dataVehicle);
                    break;
                case "7": // Sauvegarder les vehicules
                    dataVehicle.SaveVehicles();
                    break;
                case "Q":
                    Console.WriteLine("Au revoir");
                    break;
            }
        }
    }
}
