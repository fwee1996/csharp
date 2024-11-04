namespace Garage
{
    public class Tesla : BaseElectricVehicle {

//only write method overrides for CWL that is different than parent class
         public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla blazes by you. MMMMMMMmmmmmmmm!"); //Note {MainColor}. The MainColor is assigned in Program.cs
        }

        public override void Turn(string direction) 
        //note: it works if no (argument written) too like this:
        //public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Tesla squeals around a {direction} turn.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla silently stops as if it never moved.");
        }
    }
}
