using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vues
{
    public static class FormSortVehicle
    {
        public static string MenuSort()
        {
            /* TO DO : 
             * design message
             * */
            bool isValid = false;
            string sort = "";
            while (!isValid)
            {
                Console.WriteLine("Trier par 'NU' : numéro, 'MA' : marque, 'MO' : modèle, 'AN' pour annuler");
                sort = Helpers.GetStringFromConsole("Valeur ?", "", s => s.Length > 0).ToUpper();
                if (sort == "NU" || sort == "MA" || sort == "MO" || sort == "AN")
                    isValid = true;
            }

            return sort;
        }
    }
}
