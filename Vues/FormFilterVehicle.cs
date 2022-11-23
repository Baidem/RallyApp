using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vues
{
    public static class FormFilterVehicle
    {
        public static string MenuFilter()
        {
            /* TO DO : 
             * design message
             * */
            bool isValid = false;
            string filter = "";
            while (!isValid)
            {
                Console.WriteLine("Filtrer par 'MA' : marque, 'MO' : modèle, 'AN' pour annuler");
                filter = Helpers.GetStringFromConsole("Valeur ?", "", s => s.Length > 0).ToUpper();
                if (filter == "NU" || filter == "MA" || filter == "MO" || filter == "AN")
                    isValid = true;
            }

            return filter;
        }
    }
}
