using Garage;

namespace Garage{
    public abstract class BaseGasVehicle: Vehicle, IGasVehicle{
        public double FuelCapacity { get; set; } //for Ram, Cessna etc gas vehicles
        public double CurrentTankPercentage { get; set;}

        public void RefuelTank()
        {
           CurrentTankPercentage=100.0;
        }
    }
}