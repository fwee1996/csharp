namespace Garage
{
    public class Zero: BaseElectricVehicle    // Electric motorcycle
    {

         public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you. Yeeeeeoooowwwww!"); //Note {MainColor}. The MainColor is assigned in Program.cs
        }

    }
}


