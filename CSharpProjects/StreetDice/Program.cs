

Console.Clear();



static void titleCard()
{
   Random slogans = new Random();
   int topText = slogans.Next(0, 4);
   //slogans
    string slogan1 = "                       \x1b[36mThis isn't Momma's street corner anymore!\x1b[0m";
    string slogan2 = "                        \x1b[36mbetter look nice when your playing...\x1b[0m";
    string slogan3 = "                         \x1b[36m...you gonna die twice and become...\x1b[0m";
    string slogan4 = "                       \x1b[36mtoday you could be a street dice legend!\x1b[0m";
    var slogan = new string[] {
        slogan1,
        slogan2,
        slogan3,
        slogan4
    };    
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
// }  //  <----- this little bastard right HERE!!! Still was in the wrong spot
//title card
var title = $"""
         _________  __                         __    ________  .__            
        /   _____/ /  |________   ____   _____/  |_  \______ \ |__| ____  ____  
        \_____  \\    __\_  __ \_/ __ \_/ __ \   __\  |    |  \|  |/ ___\/ __ \ 
         /        \|  |  |  | \/\  ___/\  ___/|  |    |    `   \  \  \__\  ___/ 
        /_______  /|__|  |__|    \___  >\___  >__|   /_______  /__|\___  >___  >
                \/                   \/     \/               \/        \/    \/ 
                          {"STREET DICE is \x1b[33m2 Players Only\x1b[0m"}
""";
Console.WriteLine(title);
} // <--- HAHAHAA i got you!
//score card
// I am confused all to hell about these variables, I read about functions and parameters. Maybe this should work a lot easier.
/* Should be able to push everything with the scoreCard() function.
int p1cash = 100;
int p2cash = 100;
string matchFade = "???";
int p1Bet = 0;
int p2Bet = 0;  

I found a way to change the text color with this \x1b[32m green and \x1b[0m resets]
Red: \x1b[31m
Green: \x1b[32m
Yellow: \x1b[33m
Blue: \x1b[34m
Cyan: \x1b[36m
Reset: \x1b[0m

*/
static void scoreCard(int thePot, int p1cash, int p2cash, string matchFade, int p1Bet, int p2Bet)
{
Console.ForegroundColor = ConsoleColor.Green;
string scoreC = $"""
    /$$   
  /$$$$$$                 {$"\x1b[31mPot: \x1b[33m$\x1b[32m{thePot}"}
 /$$__  $$          {$"\x1b[0m-----------------\x1b[32m"}
| $$  \__/         {$"\x1b[0m| Player 1: \x1b[33m$\x1b[32m{p1cash}"}  |
|  $$$$$$          {$"\x1b[0m| Player 2: \x1b[33m$\x1b[32m{p2cash}"}  |
 \____  $$          {$"\x1b[0m-----------------\x1b[32m"}
 /$$  \ $$           {$"\x1b[0mChose to: \x1b[0m{matchFade}\x1b[32m"}
|  $$$$$$/          {$"\x1b[0mPlayer 1 Bet: \x1b[33m$\x1b[32m{p1Bet}"}
 \_  $$_/           {$"\x1b[0mPlayer 2 Bet: \x1b[33m$\x1b[32m{p2Bet}"}
   \__/   

""";
Console.Write(scoreC);
Console.ResetColor();
}
//load title card
//Console.ForegroundColor = ConsoleColor.DarkRed;
//Console.WriteLine(title);
//Console.ResetColor();

titleCard();

//dice logic
Random dice = new Random(); // cam I drop this? no
int roll = dice.Next(1, 7);
// I want to make a function for this, but I don't know how to do that yet.
//2 rolls
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
static void RollDie(int roll)
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
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
    Console.ResetColor();
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
string askPlayer = "\n                         Are you ready to play? (y/n)";
// string howManyPlayers = "How many players? (1-4)";
string hL = "\n                      Player 1 pick High or Low! (H/L)";
// int playerCount = 0;


while (true) 
{
    Console.Write(askPlayer);
    string play = Console.ReadLine().ToLower();
    if (play == "y") {
        
    
    Console.Clear();
    titleCard();  
    Console.WriteLine("                   Welcome to the streets! Let's get you set up!");
    Console.Write(hL);
    break;
    }
    else if (play == "n") {
        Console.WriteLine("\n                         \x1b[31m Maybe next time!.... punk\x1b[0m");
        Environment.Exit(0);
    }
    else {
        
        Console.WriteLine("\n                           Please enter 'y' or 'n'.");
    }   
}
// getting sloppy 


// Console.WriteLine(howManyPlayers);
// if YES

bool shooterChosen = false; // Confusing as all get out. I finally maybe have it working, all just to choose the shooter.
//string hLC = Console.ReadLine().ToUpper();  // <--- this is always orange swiggles / use  'string?'  and moved it into loop
string hLC = " ";
string hLC2 = " ";
// turning this if in to a while loop
while (true) {

    hLC = Console.ReadLine().ToUpper(); // Had to move this inside the loop
    if (hLC == "H")

    {
        hLC2 = "\x1b[33mHigh\x1b[0m"; // Awesome that the colors follow the var 
        break;
    }
    else if (hLC == "L")
    {
        hLC2 = "\x1b[34mLow\x1b[0m";
        break;
    }
    else
    {
        Console.WriteLine("                    Please enter '\x1b[33mH\x1b[0m' for High or '\x1b[34mL\x1b[0m' for Low."); // this is messing something up
        //continue; // had no clue this was a thing. I think this is looping back to the H/L question
        // COLORS weeeeeee
    }
}
Console.Clear();
titleCard();
Console.WriteLine($"                Great! {hLC2} it is! Now let's see what you will roll...");
Console.Write($"                           Press any key to continue..."); // <-- suppose to flash, but not working. Going to remove the \x1b[5m \x1b[0m additions to these pre-Ready.Key lines
Console.ReadKey();
Console.Clear();
titleCard();
Console.WriteLine("\n--- Player 1 Rolls ---");

int p1Roll1 = dice.Next(1, 7);
int p1Roll2 = dice.Next(1, 7);
RollDie(p1Roll1);
RollDie(p1Roll2);
int shooter1 = p1Roll1 + p1Roll2;
Console.WriteLine($"Player 1 rolled a total of: {shooter1}");
Console.WriteLine("\nPress any key to continue...");
Console.ReadKey();
Console.Clear();
titleCard();
Console.WriteLine(@"--- Player 2 Rolls ---" + "\nNumber to beat is: " + shooter1);
Console.WriteLine("\nPress any key to roll..."); // missed a "
Console.ReadKey();
Console.WriteLine();
// numbers for player 2
int p2Roll1 = dice.Next(1, 7);
int p2Roll2 = dice.Next(1, 7);
RollDie(p2Roll1);
RollDie(p2Roll2);
int shooter2 = p2Roll1 + p2Roll2;
Console.WriteLine($"Player 2 rolled a total of: {shooter2}\n");
Console.ReadKey();
Console.Clear();
titleCard();
while (true)
{
   
// shooter choice logic // really considering make 'switch'
if (shooter1 == shooter2) 
{
    Console.WriteLine("                                   It's a tie! Roll again!");
}
else if (shooter1 > shooter2 && hLC == "H") 
{
    Console.WriteLine("                   Player 1 rolled higher! Player 1 is the SHOOTER!");
    shooterChosen = false; // This breaks the loop! I think, I don't know it is looping back to the H/L question.
    break;
}
else if (shooter1 < shooter2 && hLC == "L") 
{
    Console.WriteLine("                   Player 1 rolled lower! Player 1 is the SHOOTER!");
    shooterChosen = false;
    break;
}
else if (shooter1 > shooter2 && hLC == "L") 
{
    Console.WriteLine("                   Player 2 rolled higher! Player 2 is the SHOOTER!");
    shooterChosen = true;
    break;
}
else if (shooter1 < shooter2 && hLC == "H") 
{
    Console.WriteLine("                   Player 2 rolled lower! Player 2 is the SHOOTER!");
    shooterChosen = true;
    break;
}
Console.Write("\n                   Press any key to continue...");
Console.ReadKey();
Console.Clear();
}
// !!! @@@ WOOOO finally, got a shooter, now the real fun.

// Slogan Selection in one line
//titleCard();

if (shooterChosen != true) 
{
    Console.WriteLine("                  Let's get this game started! Player 1 Get Ready!");
    Console.Write("                             Press any key to continue...");
    Console.ReadKey();

}
else if (shooterChosen == true)
{
    Console.WriteLine("                  Let's get this game started! Player 2 Get Ready!");
    Console.Write("                             Press any key to continue...");
    Console.ReadKey();
}

Console.Clear();
titleCard();
// Now the betting.

Console.WriteLine("\n BETTING RULES ---");
Console.Write("Each player starts with ");
//Console.ForegroundColor = ConsoleColor.Green;
Console.Write("\x1b[33m$\x1b[32m100\x1b[0m CASH \n");
//Console.ResetColor();
Console.WriteLine("\xb1[31m MATCH \x1b[0m the SHOOTER's bet to play with them.\n \xb1[31mFADE\xb1[0m to bet against the SHOOTER.");


Console.WriteLine("\n \x1b[31m!!\x1b[0m SHOOTER RULES ---");
Console.WriteLine("Roll \x1b[32m7\x1b[0m or \x1b[32m11\x1b[0m to win\n \x1b[33m2\x1b[0m, \x1b[33m3\x1b[0m, or \x1b[33m12\x1b[0m to lose.\n\x1b[31m4, 5, 6, 8, 9, or 10\x1b[0m becomes the \x1b[34mPOINT\x1b[0m \nroll that number again \x1b[32mWIN\x1b[0m\nroll a \x1b[33m7\x1b[0m \x1b[31mLOSE\x1b[0m dice and money\nGood luck!\nWhen done reading, press any key to continue...");
Console.ReadKey();
Console.Clear();
//       (int thePot, int p1cash, int p2cash, string matchFade, int p1Bet, int p2Bet)
scoreCard(000, 100, 100, "MATCH", 20, 20); // <---- this isn't working / I did now, good lord. AGAIN! not working. Oh yeah duh
// this scoreCard and Betting system is going to get crazy.

// BETTING
Console.WriteLine("\nPlayer 1, place your bet! (enter a number)");
int p1PlaceBet = 0;
while (true)
{
    string p1BetInput = Console.ReadLine();
    if (int.TryParse(p1BetInput, out p1PlaceBet) && p1PlaceBet > 0 && p1PlaceBet <= 100)
    {
        break;
    }
    else
    {
        Console.WriteLine("\x1b[32mPlease enter a valid bet amount between 1 and 100.\x1b[0m");
    }
}
Console.WriteLine($"Player 1 has placed a bet of $\x1b[33m{p1PlaceBet}\x1b[0m.");
Console.WriteLine("\nAny key for Player 2...");
Console.ReadKey();
int p2PlaceBet = 0;
while (true)
{
    Console.WriteLine("\nPlayer 2, will you MATCH or FADE Player 1's bet? [M/F]");
    string p2BetInput = Console.ReadLine();
    if (p2BetInput.ToUpper() == "M")
    {
        Console.WriteLine($"\nPlayer 2, MATCH bet! {p1PlaceBet} it is!");
        p2PlaceBet = p1PlaceBet;
        break;
    }
    else if (p2BetInput.ToUpper() == "F")
    {
        Console.WriteLine("\nPlayer 2, place your FADE bet! (enter a number)");
        break;
    }
    else
    {
        Console.WriteLine("\x1b[32mPlease enter a valid bet amount between 1 and 100.\x1b[0m");
    }
}
Console.WriteLine($"Player 2 has placed a bet of $\x1b[33m{p2PlaceBet}\x1b[0m.");



// Fresh Bottom , ohhhh yeah


