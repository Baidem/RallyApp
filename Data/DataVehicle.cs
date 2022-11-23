using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [Serializable]
    public class DataVehicle
    {
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public DataVehicle()
        {
        }
        public void IntializeList()
        {
            var c1 = new Car(5000, "Ford", "Fiesta", 235);
            var c2 = new Car(2000, "Ford", "Fiesta", 235);
            var c3 = new Car(3000, "Subaru", "Impreza WRX STI", 310);
            var c4 = new Car(4000, "Subaru", "Impreza WRX STI", 310);
            var c5 = new Car(1000, "Mitsubishi", "Lancer Eco 9", 280);
            var c6 = new Car(6000, "Mitsubishi", "Lancer Eco 10", 295);
            var c7 = new Car(7000, "Peugeot", "207", 280);
            var c8 = new Car(8000, "Volkswagen", "Golf 3 GTI", 275);
            var c9 = new Car(9000, "Peugeot", "309 GTI", 240);
            var c10 = new Car(10000, "Renault", "5 GT TURBO", 160);
            Vehicles.Add(c1);
            Vehicles.Add(c2);
            Vehicles.Add(c3);
            Vehicles.Add(c4);
            Vehicles.Add(c5);
            Vehicles.Add(c6);
            Vehicles.Add(c7);
            Vehicles.Add(c8);
            Vehicles.Add(c9);
            Vehicles.Add(c10);

            var t1 = new Truck(1100, "DAF", "Turbo Twin", 10500);
            var t2 = new Truck(1200, "DAF", "F3300", 10500);
            Vehicles.Add(t1);
            Vehicles.Add(t2);
        }
        public void AddCar(Car car)
        {
            Vehicles.Add(car);
        }
        public void AddTruck(Truck truck)
        {
            Vehicles.Add(truck);
        }
        public Vehicle? GetVehicleByNumber(int nb)
        {
            var vh = Vehicles.FirstOrDefault(v => v.Number == nb);
            return vh;
        }
        public void SaveVehicles()
        {
            try
            {
                using (var stream = new FileStream("VehicleList.bin", FileMode.OpenOrCreate, FileAccess.Write))
                { // Memory to disk
                    var binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(stream, this.Vehicles);

                    Console.WriteLine("Sauvegardé :");
                    foreach (var v in this.Vehicles) { Console.WriteLine(v); }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur de la sauvegarde du fichier {e.Message}");
            }
        }

        public void LoadList()
        {
            if (File.Exists("VehicleList.bin"))
            {
                try
                {
                    using (var fileStreamRead = new FileStream("VehicleList.bin", FileMode.Open, FileAccess.Read))
                    { // Disk to memory
                        var binaryFormatter = new BinaryFormatter();
                        var vehicleList = binaryFormatter.Deserialize(fileStreamRead) as List<Vehicle>;
                        if (vehicleList is List<Vehicle>)
                            this.Vehicles = vehicleList;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erreur du chargement du fichier {e.Message}");
                }
            }
        }
    }
}
