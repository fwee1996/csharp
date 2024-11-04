
//You should complete the classes in this order:
// 6.UpperHalfPlayer
namespace ShootingDice
{
// TODO: Complete this class

// A Player whose role will always be in the upper half of their possible rolls
public class UpperHalfPlayer: Player
{

      public override int Roll()
        {
//In C#, you can create an instance of Random and use it immediately without storing it in a variable.
//new Random().Next(minValue, maxValue) creates a new Random object and immediately calls its Next method.
        return new Random().Next((DiceSize / 2) + 1, DiceSize + 1); //note: DiceSize + 1 =7 that is the max value so that it INCLUDES 6!
        }
}
}
