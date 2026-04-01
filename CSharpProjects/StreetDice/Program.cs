// lil nasty down there right now.
// var 
Random slogans = new Random();
int topText = slogans.Next(0, 4);
Random dice = new Random();
int roll = dice.Next(1, 7);

//slogans
string slogan1 = "                       This isn't momma's street corner anymore!";
string slogan2 = "                          Gotta look nice when your playing...!";
string slogan3 = "                         ...you gonna die twice and become...!";
string slogan4 = "                        today you could be a street dice legend!";
var slogan = new string[] {
    slogan1,
    slogan2,
    slogan3,
    slogan4
};
//player setup
string askPlayer = "Would you like to play? (y/n)";
string howManyPlayers = "How many players? (1-4)";
int playerCount = 0;

//title card
var title = """
         _________  __                         __    ________  .__            
        /   _____/ /  |________   ____   _____/  |_  \______ \ |__| ____  ____  
        \_____  \\    __\_  __ \_/ __ \_/ __ \   __\  |    |  \|  |/ ___\/ __ \ 
         /        \|  |  |  | \/\  ___/\  ___/|  |    |    `   \  \  \__\  ___/ 
        /_______  /|__|  |__|    \___  >\___  >__|   /_______  /__|\___  >___  >
                \/                   \/     \/               \/        \/    \/ 

""";

// Slogan Selection
switch (topText) {
    case 0:
        Console.WriteLine(slogan[0]);
        break;
    case 1:
        Console.WriteLine(slogan[1]);
        break;
    case 2:
        Console.WriteLine(slogan[2]);
        break;
    case 3:
        Console.WriteLine(slogan[3]);
        break;
    default:
        Console.WriteLine(slogan[0]);
        break;
}


Console.WriteLine(title);
Console.WriteLine(askPlayer);
string play = "";
switch (play) {
    case "y":
        Console.WriteLine(howManyPlayers);
        playerCount = (Console.ReadLine()) 
        switch {
            "1" => 1,
            "2" => 2,
            "3" => 3,
            "4" => 4,
            _ => 0
        };
        if (playerCount > 0) {
            Console.WriteLine($"Great! We have {playerCount} players ready to go!");
        } else {
            Console.WriteLine("Please enter a valid number of players (1-4).");
        }
    case "n":
        Console.WriteLine("Maybe next time!");
        break;
    default:
        Console.WriteLine("Please enter 'y' or 'n'.");
        break;
}

//dice logic

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
static void RollDie(int roll)
{
    switch (roll)
    {
        case 1:
            Console.WriteLine(" ------- \n|       |\n|   o   |\n|       |\n ------- "); // <-- removed Line to see if it will show the dice side by side, instead of one on top of the other.
            break;
        case 2:
            Console.WriteLine(" ------- \n|   o   |\n|       |\n|   o   |\n ------- "); // triend the slash n at the end, still stacked.
            break;
        case 3:
            Console.WriteLine(" ------- \n| o     |\n|   o   |\n|     o |\n ------- ");
            break;
        case 4:
            Console.WriteLine(" ------- \n| o   o |\n|       |\n| o   o |\n ------- ");
            break;
        case 5:
            Console.WriteLine(" ------- \n| o   o |\n|   o   |\n| o   o |\n ------- ");
            break;
        case 6:
            Console.WriteLine(" ------- \n| o   o |\n| o   o |\n| o   o |\n ------- ");
            break;
        
    }
} 
// I don't get functions yet obvliously !!!!!!!!!!! OMG really. 
// these babies wanna stack.

/*/ rewards
!!! I don't know about these. I want more of a competitive game
int totalScore = roll1 + roll2;

if (roll1 == 1 && roll2 == 1)
{
    Console.WriteLine("Snake Eyes! You lose everything!");
}
else if (roll1 == roll2)
{
    Console.WriteLine("Doubles! You get to roll again!");
}
else if (totalScore == 7 || totalScore == 11)
{
    Console.WriteLine("Winner winner, chicken dinner!");
}
else
{
    Console.WriteLine($"You scored {totalScore}. Nothing special happens.");
}
*/
Console.WriteLine(howManyPlayers);

RollDie(roll1);
RollDie(roll2);
Console.WriteLine($"You rolled: {roll1} and {roll2}");
// 
// i'm getting double rolls for some reason
// going to use VSCode's Source Control for the first time, in this project.