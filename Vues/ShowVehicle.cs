using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vues
{
    public static class ShowVehicle
    {
        public static void line(Vehicle vehicle)
        {
            Console.WriteLine(vehicle);
        }
        public static void Column(Vehicle vehicle)
        {
            vehicle.ToStringColomn();
        }

    }
}
