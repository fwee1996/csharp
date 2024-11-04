//You should complete the classes in this order:
// 5.SoreLoserPlayer

namespace ShootingDice
{
// TODO: Complete this class

// A Player that throws an exception when they lose to the other player
// Where might you catch this exception????
public class SoreLoserPlayer: Player
{

public override void Play(Player other)
    {
        // Call roll for "this" object and for the "other" object
        int myRoll = Roll();
        int otherRoll = other.Roll();

        Console.WriteLine($"{Name} rolls a {myRoll}");
        Console.WriteLine($"{other.Name} rolls a {otherRoll}");
        if (myRoll > otherRoll)
        {
            Console.WriteLine($"{Name} Wins!");
        }
        else if (myRoll < otherRoll)
        {
            Console.WriteLine($"{other.Name} Wins!");
            //throws an exception when they lose to the other player----------------------------------
            throw new Exception($"{Name} says: I don't accept this! This is rigged!");
        }
        else
        {
            // if the rolls are equal it's a tie
            Console.WriteLine("It's a tie");
        }
    }
}
}
