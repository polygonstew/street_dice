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
                                2 Players Only
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


/*/ Game Rules:
 2 dice and cash   
 pick a shooter - ask player for H or L high or low, winner is the closest to either H or L
    !- Program in a H or L choice
betting system - start with 100 dollars, bet on each round, win or lose money based on outcome
    !- Program in a betting system and asign each player 100 dollars to start
gotta match or fade (put down or pass)
first roll is THE COMEOUT if Shooter rolls(7 or 11 ) !!- WINS THE POT
                      if Shooter rolls (2, 3, or 12) !!- LOSES THE POT
 first round is the COMEOUT, if the shooter rolls (4, 5, 6, 8, 9, or 10) that number becomes the POINT
    - Shooter keeps rolling until they roll the POINT again !!!-(WIN) or a 7 !!!-(LOSE) 
    pass to the next player and repeat until one player has all the money or everyone but one player is broke.
    FADE - if you think the shooter will lose, you can choose to ???-FADE and ???-BET against them. 
    If they win, you lose your bet, if they lose, you win your bet. 
    You can also choose to match and bet with the shooter. 
    If they win, you win your bet, if they lose, you lose your bet.
 


 /*/


//player setup
string askPlayer = "Are you ready to play? (y/n)";
// string howManyPlayers = "How many players? (1-4)";
string hL = "Someone pick High or Low! (H/L)";
// int playerCount = 0;

//asking

Console.WriteLine(askPlayer);
string play = Console.ReadLine().ToLower();
if (play == "y") {
        
        
    Console.WriteLine("Welcome to the streets! Let's get you set up!\n");
    Console.Write(hL);
    }
    else if (play == "n") {
        Console.WriteLine("Maybe next time!.... punk");
    }
    else {
        Console.WriteLine("Please enter 'y' or 'n'.");
    }   
     
// getting sloppy 
bool shooterChosen = false;
// Console.WriteLine(howManyPlayers);
// if YES
string hLC = (Console.ReadLine());
Console.WriteLine($"Great! {hLC} it is! Now let's see what you will roll...");
RollDie(roll1);
RollDie(roll2);
Console.WriteLine($"You rolled: {roll1} and {roll2}");
int shooter1 = roll1 + roll2;
Console.WriteLine("Player 2 rolls...");
RollDie(roll1);
RollDie(roll2);
Console.WriteLine($"You rolled: {roll1} and {roll2}");
int shooter2 = roll1 + roll2;
if (shooter1 > shooter2 && hLC == "H") {
        Console.WriteLine("Player 1 wins! You are the SHOOTER!");
        shooterChosen = true;
    }
    else if (shooter1 < shooter2 && hLC == "L") {
        Console.WriteLine("Player 1 wins! You are the SHOOTER!");
        shooterChosen = true;
    }
    else if (shooter1 > shooter2 && hLC == "L") {
        Console.WriteLine("Player 2 wins! You are the SHOOTER!");
        shooterChosen = false;
    }
    else if (shooter1 < shooter2 && hLC == "H") {
        Console.WriteLine("Player 2 wins! You are the SHOOTER!");
        shooterChosen = false;
    }
    else {
        Console.WriteLine("It's a tie! Roll again!");
    }

// 
// i'm getting double rolls for some reason
// going to use VSCode's Source Control for the first time, in this project.