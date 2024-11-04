//gas RV

namespace Garage
{
    public class AirstreamRV: BaseGasVehicle
    {

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} AirstreamRV zooms by you. ZZZZZZooooommm!"); //Note {MainColor}. The MainColor is assigned in Program.cs
        }
         

    }
}