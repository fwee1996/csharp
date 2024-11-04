using ShootingDice;

//alt:Player player1 = new Player { Name = "Bob" };
Player player1 = new Player();
player1.Name = "Bob";

Player player2 = new Player();
player2.Name = "Sue";

player2.Play(player1);

Console.WriteLine("-------------------");

Player player3 = new Player();
player3.Name = "Wilma";

player3.Play(player2);

Console.WriteLine("-------------------");

Player large = new LargeDicePlayer();
large.Name = "Bigun Rollsalot";

player1.Play(large);

Console.WriteLine("-------------------");

Player smackPlayer = new SmackTalkingPlayer();
smackPlayer.Name = "Taunter";

player1.Play(smackPlayer);

Console.WriteLine("-------------------");

OneHigherPlayer oneHigher = new OneHigherPlayer();
oneHigher.Name = "One Up";
oneHigher.Play(player1);

Console.WriteLine("-------------------");

HumanPlayer humanPlayer = new HumanPlayer ();
humanPlayer.Name = "Human";
humanPlayer.Play(player1);

Console.WriteLine("-------------------");

CreativeSmackTalkingPlayer creativeSmack = new CreativeSmackTalkingPlayer();
creativeSmack.Name = "Creative Taunter";
creativeSmack.Play(player1);

Console.WriteLine("-------------------");

UpperHalfPlayer upperHalf = new UpperHalfPlayer();
upperHalf.Name = "Upper Half";
upperHalf.Play(player1);

Console.WriteLine("-------------------");

//those with Exception: SoreLoser and SoreLoserUpperHalf
//SoreLoser 
try
{
    SoreLoserPlayer soreLoser = new SoreLoserPlayer ();
    soreLoser.Name = "Sore Loser";
    soreLoser.Play(player1);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("-------------------");

//SoreLoserUpperHalf
try
{
    SoreLoserUpperHalfPlayer soreLoserUpper = new SoreLoserUpperHalfPlayer();
    soreLoserUpper.Name = "Sore Loser Upper";
    soreLoserUpper.Play(player1);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("-------------------");



List<Player> players = new List<Player>() {
    player1, player2, player3, large, smackPlayer, oneHigher, humanPlayer, creativeSmack, upperHalf
};

PlayMany(players);

static void PlayMany(List<Player> players)
{
    Console.WriteLine();
    Console.WriteLine("Let's play a bunch of times, shall we?");

    // We "order" the players by a random number
    // This has the effect of shuffling them randomly
    Random randomNumberGenerator = new Random();
    List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

    // We are going to match players against each other
    // This means we need an even number of players
    int maxIndex = shuffledPlayers.Count;
    if (maxIndex % 2 != 0)
    {
        maxIndex = maxIndex - 1;
    }

    // Loop over the players 2 at a time
    for (int i = 0; i < maxIndex; i += 2)
    {
        Console.WriteLine("-------------------");

        // Make adjacent players play one another
        Player player1 = shuffledPlayers[i];
        Player player2 = shuffledPlayers[i + 1];
        player1.Play(player2);
    }
}




// After completing each class, use it to create one or more Player objects in Program.cs. Write code to test these new objects.
// Add the new Player object(s) to the players list, so they will be passed to the PlayMany() method.

