namespace Garage
{
    public class Ram: BaseGasVehicle  // Gas powered truck
    {
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram growls by you. RRRRRRRuuummmbbble!"); //Note {MainColor}. The MainColor is assigned in Program.cs
        }
         

    }
}