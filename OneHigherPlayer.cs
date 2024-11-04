//You should complete the classes in this order:
// 2.OneHigherPlayer

namespace ShootingDice
{
// TODO: Complete this class

// Override the Play method to make a Player who always roles one higher than the other player
public class OneHigherPlayer: Player
{
public override void Play(Player other)
        {
            //This player always rolls one higher than the other player.
            int otherRoll = other.Roll();
            int myRoll = otherRoll + 1; // Always roll one higher

        //below copied from Palyer.cs
        Console.WriteLine($"{Name} rolls a {myRoll}");
        Console.WriteLine($"{other.Name} rolls a {otherRoll}");
        if (myRoll > otherRoll)
        {
            Console.WriteLine($"{Name} Wins!");
        }
        else if (myRoll < otherRoll)
        {
            Console.WriteLine($"{other.Name} Wins!");
        }
        else
        {
            // if the rolls are equal it's a tie
            Console.WriteLine("It's a tie");
        }
        }
}

}
