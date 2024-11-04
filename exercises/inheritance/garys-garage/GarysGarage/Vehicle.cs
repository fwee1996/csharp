namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public int NumWheels { get; set; }
        public int NumDoors { get; set; }

         public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; }

        // public virtual void ChargeBattery()
        // {
        //      CurrentChargePercentage=100.0;
        // }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
         public virtual void Turn(string direction)
        //public virtual void Turn()
        {
            Console.WriteLine($"The vehicle carefully turns {direction}");
        }

        public virtual void Stop()
        {
            Console.WriteLine($"The vehicle gently rolls to a stop!");
        }


    }
}


