// //You should complete the classes in this order:
// // 4.CreativeSmackTalkingPlayer

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private List<string> Taunts { get; } = new List<string>
        {
            "You're going down!",
            "Is that all you got?",
            "Better luck next time!",
            "You can't beat me!",
            "Prepare to lose!",
            "My grandma can do better than that!",
            "You're an amateur, go sit at the kids' table"
        };

        private Random random = new Random();

        public override int Roll()
        {
            // Randomly select a taunt from the list ListName[random index]
            string taunt = Taunts[random.Next(Taunts.Count)];
            // Print the selected taunt
            Console.WriteLine($"{Name} says: {taunt}");
            return base.Roll();
        }
    }
}
