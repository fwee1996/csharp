// //You should complete the classes in this order:
// // 3.HumanPlayer

// namespace ShootingDice
// {
// // TODO: Complete this class

// // A player the prompts the user to enter a number for a roll
// public class HumanPlayer: Player
// {
//     public override int Roll(){ //int instead of void because returning an int from readline
//         Console.WriteLine("Enter number of rolls between 1 and {DiceSize}: ");
//         int NumRolls = int.Parse(Console.ReadLine());
//         return NumRolls; //bcs you wrote override int it must return int that is the Number of rolls!
//     }

// }
// }



namespace ShootingDice
{
    // A Player who prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine($"Enter number of rolls between 1 and {DiceSize}:");
            int userRoll;
            while (!int.TryParse(Console.ReadLine(), out userRoll) || userRoll < 1 || userRoll > DiceSize)
            {
                Console.WriteLine($"Please enter a valid number between 1 and {DiceSize}:");
            }
            return userRoll;
        }
    }
}
