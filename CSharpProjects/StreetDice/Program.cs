// lil nasty down there right now.
// var 
Random slogans = new Random();
int topText = slogans.Next(0, 4);

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

//load title card
Console.WriteLine(title);



//dice logic
Random dice = new Random(); // cam I drop this? no
int roll = dice.Next(1, 7);
// I want to make a function for this, but I don't know how to do that yet.
//2 rolls
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
//player setup
string askPlayer = "Are you ready to play? (y/n)";
string howManyPlayers = "How many players? (1-4)";
int playerCount = 0;

//asking

Console.WriteLine(askPlayer);
string play = Console.ReadLine().ToLower();
if (play == "y") {
        
        
    Console.WriteLine("Welcome to the streets! Let's get you set up!");
    }
    else if (play == "n") {
        Console.WriteLine("Maybe next time!.... punk");
    }
    else {
        Console.WriteLine("Please enter 'y' or 'n'.");
    }   
     
// getting sloppy 

Console.WriteLine(howManyPlayers);
playerCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Great! We have {playerCount} players ready to go!");


RollDie(roll1);
RollDie(roll2);
Console.WriteLine($"You rolled: {roll1} and {roll2}");
// 
// i'm getting double rolls for some reason
// going to use VSCode's Source Control for the first time, in this project.