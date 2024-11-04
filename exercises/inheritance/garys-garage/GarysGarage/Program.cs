// //Part 1: Chapter 19 Inheritance
// namespace Garage
// {
//     class Program
//     {
//         static void Main(string[] args) 
//         {
//             Zero fxs = new Zero()
//             {
//                 MainColor="Midnight Blue",
//                 MaximumOccupancy=1,
//                 BatteryKWh=7.2 //note: only Tesla and Zero have this property!
//             };

//             Zero fxs1 = new Zero()
//             {
//                 MainColor="Black",
//                 MaximumOccupancy=1,
//                 BatteryKWh=7.2
//             };

//             Tesla modelS = new Tesla()
//             {
//                 MainColor="Burgundy",
//                 MaximumOccupancy=1,
//                 BatteryKWh=100.0 
//             };


//             Cessna mx410 = new Cessna()
//             {
//                 MainColor="White",
//                 MaximumOccupancy=4,
//                 FuelCapacity=26.0 //note: only Cessna and Ram have this property!
//             };

    
//             Ram ram1= new Ram()
//             {
//                 MainColor="Silver",
//                 MaximumOccupancy=1,
//                 FuelCapacity=33.0
//             };



//             fxs.Drive();
//             fxs.Turn("right"); //note ASSIGN DIRECTION within where method called!
//             fxs.Stop();

//         Console.WriteLine(); //line break

//             fxs1.Drive();
//             fxs1.Turn("right"); 
//             fxs1.Stop();
            
//         Console.WriteLine(); //line break

//             modelS.Drive();
//             modelS.Turn("right"); 
//             modelS.Stop();
            
//         Console.WriteLine(); //line break

//             ram1.Drive();
//             ram1.Turn("right"); 
//             ram1.Stop();
            
//         Console.WriteLine(); //line break

//             mx410.Drive();
//             mx410.Turn("right");
//             mx410.Stop();

//         }
//     }
// }




//Part2: Chapter 20 Practice: Interface -- More Gary's Wholesale Garage
//add BOat rv jetski scooter
//Gas-jetski, rv, boat
//electric-vespa
// Now, all of these types of things have some attributes and behaviors in common.

// They all have an engine --gas or electric RefuelTank()// ChargeBattery()
// They all carry one, or more, passenger --MaximumOccupancy
// They all move ---Drive()
// They all accelerate in any direction --Accelerate()?
// There are other attributes and behaviors that some specific kinds of these vehicles share, but others don't.

// Some use gas
// Some are electric
// Some use a propeller to move (boat)
// Some have wheels
// Some have doors
// Some use a jet to move

namespace Garage
{
    class Program
    {
        static void Main (string[] args)
        {
            // Zero fxs = new Zero();
            // Zero fx = new Zero();
            // Tesla modelS = new Tesla();
            // Vespa vespa1 = new Vespa();


            Zero fxs = new Zero()
            {
                MainColor="Midnight Blue",
                MaximumOccupancy=1,
                NumWheels = 2,
                BatteryKWh=9.2, //note: only Tesla and Zero have this property!
                CurrentChargePercentage=50.0,
            };

            Zero fxs1 = new Zero()
            {
                MainColor="Black",
                MaximumOccupancy=1,
                NumWheels = 2,
                BatteryKWh=7.2,
                CurrentChargePercentage = 70.0 
            };

            Tesla modelS = new Tesla()
            {
                //prop in Vehicle.cs:
                MainColor="Burgundy",
                MaximumOccupancy=1,
                NumWheels = 4,
                NumDoors = 4, 
                BatteryKWh=10.0, //note: only Tesla and Zero have this property!
                CurrentChargePercentage=80.0,
            };

            Vespa vespa1 = new Vespa()
            {
                MainColor="Baby blue",
                MaximumOccupancy=1,
                NumWheels = 2, 
                BatteryKWh=10.0,
                CurrentChargePercentage=40.0,
            };

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() { fxs, fxs1, modelS, vespa1 };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"Current Charge: {ev.CurrentChargePercentage}");
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"After Charging: {ev.CurrentChargePercentage}");
            }

            /***********************************************/

            // Ram ram = new Ram ();
            // Cessna cessna150 = new Cessna ();
            // AirstreamRV airstreamRV= new AirstreamRV();
            // YamahaJetSki yamahaJetSki=new YamahaJetSki();
            // SeaRayBoat seaRayBoat= new SeaRayBoat();

            Cessna cessna150 = new Cessna()
            {
                MainColor="White",
                MaximumOccupancy=4,
                FuelCapacity=26.0,
                CurrentTankPercentage=30.0, 
            };
    
            Ram ram= new Ram()
            {
                MainColor="Silver",
                MaximumOccupancy=1,
                NumWheels = 4,
                NumDoors = 4, 
                FuelCapacity=85.0,                
                CurrentTankPercentage=40.0, 
            };

            AirstreamRV airstreamRV= new AirstreamRV()
            {
                MainColor="Silver",
                MaximumOccupancy=1,
                NumWheels = 4,
                NumDoors = 2, 
                FuelCapacity=60.0,
                CurrentTankPercentage=50.0, 
            };
            YamahaJetSki yamahaJetSki=new YamahaJetSki()
            {
                MainColor="Silver",
                MaximumOccupancy=1,
                FuelCapacity=63.0,
                CurrentTankPercentage=60.0, 
            };

            SeaRayBoat seaRayBoat= new SeaRayBoat()
            {
                MainColor="Silver",
                MaximumOccupancy=1,
                FuelCapacity=33.0,
                CurrentTankPercentage=70.0, 
            };

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150, airstreamRV, yamahaJetSki, seaRayBoat
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"Current Fuel: {gv.CurrentTankPercentage}");
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"After Refuel: {gv.CurrentTankPercentage}");
            }
        }
    }
}
