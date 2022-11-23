using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vues
{
    public static class Menu
    {
        public static void menu()
        {
            /* Summary :
             * This method displays the main text menu.
             *  TO DO: Design it.
             * */
            Console.WriteLine("");
            Console.WriteLine($"   Quelle action ?");
            Console.WriteLine($" 0 - liste des véhicules");
            Console.WriteLine($" 1 - Créer un véhicule");
            Console.WriteLine($" 2 - Voir un véhicule");
            Console.WriteLine($" 3 - Mettre à jour un véhicule");
            Console.WriteLine($" 4 - Supprimer un véhicule");
            Console.WriteLine($" 5 - Trier les véhicules");
            Console.WriteLine($" 6 - Filtrer les véhicules");
            Console.WriteLine($" 7 - Sauvegarder les véhicules");
            Console.WriteLine("");
            Console.WriteLine($" Q - Pour Quitter");
            Console.WriteLine("");
        }

    }
}
