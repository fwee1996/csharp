//You should complete the classes in this order:
// 1.SmackTalkingPlayer


namespace ShootingDice
{
// TODO: Complete this class

// A Player who shouts a taunt every time they roll dice
public class SmackTalkingPlayer: Player
{
    public string Taunt { get; }   = "I'm the best!";
    //get only: This is appropriate if the Taunt is set once (perhaps in the constructor) and never changed afterward.
//get and set: This is suitable if you need to modify the Taunt after the object has been created.

    public override int Roll()
        {
            //shouts a taunt:
            Console.WriteLine($"{Name} says: {Taunt}");    //($"{Name} says: {Taunt}");
            
            //every time they roll dice:
            return base.Roll(); //base.Play(other) calls the Play method defined in the Player base class. 
        //Returning base.Roll() ensures that the method still performs the dice roll functionality defined in the base Player class while adding the additional behavior of taunting.
        }
}
}
