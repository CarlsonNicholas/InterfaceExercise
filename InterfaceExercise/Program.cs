using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car Civic = new Car() { IsConvertable = false , IsLuxury = false, Door = 4, Headlights = true, Logo = "Honda", NationOfOrigin = "Japan", Trunk = true, Windsheild = true};
            SUV CRV = new SUV() {PassangerCapacity = 5, HasRoofRack = true, Door = 4, Headlights = true, Logo = "Honda", NationOfOrigin = "Japan", Trunk = true, Windsheild = true};
            Truck Ram = new Truck() {HasPullBar = true, TowCapacity = "7,000 pounds", Door = 2, Headlights = true, Logo = "Dodge", NationOfOrigin = "United States", Windsheild = true, Trunk 
            = false};

            List<IVehicle> VehicleList = new List<IVehicle>();
            List<ICompany> CompanyList = new List<ICompany>();
            List<Car> CarList = new List<Car>();
            List<SUV> SuvList = new List<SUV>();    
            List<Truck> TruckList = new List<Truck>();  

            VehicleList.Add(Civic);
            VehicleList.Add(CRV);
            VehicleList.Add(Ram);

            CompanyList.Add(Civic);
            CompanyList.Add(CRV);
            CompanyList.Add(Ram);

            CarList.Add(Civic);

            SuvList.Add(CRV);

            TruckList.Add(Ram);


            foreach (IVehicle vehicle in VehicleList) 
            {
                Console.WriteLine($"Door: {vehicle.Door}");
                Console.WriteLine($"Headlights: {vehicle.Headlights}");
                Console.WriteLine($"Trunk: {vehicle.Trunk}");
                Console.WriteLine($"Windshield: {vehicle.Windsheild}");
                Console.WriteLine($"");
            }

            foreach (ICompany company in CompanyList)
            {
                Console.WriteLine($"Logo: {company.Logo}");
                Console.WriteLine($"Nation Of Origin: {company.NationOfOrigin} ");
                Console.WriteLine($"");
            }

            foreach (Car car in CarList) 
            { 
              Console.WriteLine($"Is Convertible: {car.IsConvertable}");
              Console.WriteLine($"Is Luxury: {car.IsLuxury}");
              Console.WriteLine($"");
            }

            foreach (SUV SUV in SuvList) 
            {
              Console.WriteLine($"Passanger Capacity: {SUV.PassangerCapacity}");
              Console.WriteLine($"Has Roof Rack: {SUV.HasRoofRack}");
              Console.WriteLine($"");
            }

            foreach (Truck Truck in TruckList) 
            {
              Console.WriteLine($"Has Pullbar: {Truck.HasPullBar}");
              Console.WriteLine($"Tow Capacity: {Truck.TowCapacity}");
              Console.WriteLine($"");

            }
            

        }
    }
}
