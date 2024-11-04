//electric scooter
namespace Garage
{
    public class Vespa: BaseElectricVehicle   // Electric scooter
    {
        
         public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Vespa zips by you. Yeeeeeoooowwwww!"); 
        }
        
    }
}
