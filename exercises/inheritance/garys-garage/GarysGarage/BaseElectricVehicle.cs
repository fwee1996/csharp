namespace Garage{
    public abstract class BaseElectricVehicle: Vehicle, IElectricVehicle{
        //abstract:define common methods and properties that other classes MUST implement

    //note: if you inherit IElectricVehicle you must implement properties defined in the IElectricVehicle 
    //interface, that is: 
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; }
        
        public void ChargeBattery()
        {
            //Charge vehicle to 100% Battery
            CurrentChargePercentage=100.0;
        }
    }
}