namespace Garage
{
    public interface IGasVehicle
    {
        double FuelCapacity { get; set; } //for Ram, Cessna etc gas vehicles
        double CurrentTankPercentage { get; set;}
        void RefuelTank();
    }
}
