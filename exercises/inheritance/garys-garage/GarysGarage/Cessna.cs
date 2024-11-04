namespace Garage
{
    public class Cessna : BaseGasVehicle //Cessna is light  aircraft
    {

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flashes by you like a hurricane. ZZZZZZZooooommmmm!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The white Cessna rolls down the runway for a mile and stops.");
        }
    }
}
