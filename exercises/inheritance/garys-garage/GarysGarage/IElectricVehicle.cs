namespace Garage
{
    public interface IElectricVehicle
    {
        double BatteryKWh { get; set; } //for Tesla, Zero etc electric vehicle
        double CurrentChargePercentage { get; set;}
        void ChargeBattery();
    }
}
