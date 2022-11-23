// See https://aka.ms/new-console-template for more information
using Entities;
using Data;
using Services;
using Logic;
using System.Runtime.CompilerServices;
using Vues;
using System.Xml.Serialization;

Console.WriteLine("The Rally Application");

DataVehicle dataVehicle = new();
dataVehicle.LoadList();
if (dataVehicle.Vehicles.Count() <= 0)
{
    dataVehicle.IntializeList();
}
ShowList.Vehicle(dataVehicle.Vehicles);

string choice = "";
while (choice.ToUpper() != "Q")
{
    Menu.menu();
    choice = Helpers.GetStringFromConsole("Valeur ?", "", s => s.Length > 0);
    SMenu.Action(choice, dataVehicle);
}


