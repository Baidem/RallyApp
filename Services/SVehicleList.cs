using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;

namespace Services
{
    public class SVehicleList
    {
        public List<Vehicle> GetVehicleList(DataVehicle dataVehicle)
        {
            List<Vehicle> vehicleList = dataVehicle.Vehicles;
            return vehicleList;
        }
    }
}
