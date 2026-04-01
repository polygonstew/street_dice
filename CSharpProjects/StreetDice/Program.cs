

Console.Clear();



static void titleCard()
{
   Random slogans = new Random();
   int topText = slogans.Next(0, 4);
   //slogans
    string slogan1 = "                       This isn't Momma's street corner anymore!";
    string slogan2 = "                         better look nice when your playing...";
    string slogan3 = "                         ...you gonna die twice and become...";
    string slogan4 = "                        today you could be a street dice legend!";
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
}  //  <----- this little bastard right HERE!!! 
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
//score card
// I am confused all to hell about these variables, I read about functions and parameters. Maybe this should work a lot easier.
/* Should be able to push everything with the scoreCard() function.
int p1cash = 100;
int p2cash = 100;
string matchFade = "???";
int p1Bet = 0;
int p2Bet = 0;  
*/
static void scoreCard(int thePot, int p1cash, int p2cash, string matchFade, int p1Bet, int p2Bet)
{
Console.ForegroundColor = ConsoleColor.Green;
string scoreC = $"""
    /$$   
  /$$$$$$                 Pot: ${thePot}
 /$$__  $$          -----------------
| $$  \__/         | Player 1: ${p1cash}  |
|  $$$$$$          | Player 2: ${p2cash}  |
 \____  $$          -----------------
 /$$  \ $$           Chose to:{matchFade}
|  $$$$$$/          Player 1 Bet: ${p1Bet}
 \_  $$_/           Player 2 Bet: ${p2Bet}
   \__/   

""";
Console.Write(scoreC);
Console.ResetColor();
}
//load title card
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine(title);
Console.ResetColor();

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
string askPlayer = "\n                         Are you ready to play? (y/n)";
// string howManyPlayers = "How many players? (1-4)";
string hL = "\n                      Someone pick High or Low! (H/L)";
// int playerCount = 0;


while (true) 
{
    Console.Write(askPlayer);
    string play = Console.ReadLine().ToLower();
    if (play == "y") {
        
    
    Console.Clear();
    titleCard();  
    Console.WriteLine("                   Welcome to the streets! Let's get you set up!\n");
    Console.Write(hL);
    break;
    }
    else if (play == "n") {
        Console.WriteLine("\n                       Maybe next time!.... punk");
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
string hLC = Console.ReadLine().ToUpper();  // <--- this is always orange swiggles / use  'string?'  and moved it into loop
string hLC2 = " ";    
if (hLC == "H")
    {
        hLC2 = "High";
    }
    else if (hLC == "L")
    {
        hLC2 = "Low";
    }
    else
    {
        Console.WriteLine("                    Please enter 'H' for High or 'L' for Low."); // this is messing something up
        //continue; // had no clue this was a thing. I think this is looping back to the H/L question
    }
Console.Clear();
titleCard();
Console.WriteLine($"                Great! {hLC2} it is! Now let's see what you will roll...");
Console.WriteLine($"                           Press any key to continue...");
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
Console.WriteLine("\nPress any key to roll...");
Console.ReadKey();
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
Console.WriteLine("\n                   Press any key to continue...");
Console.ReadKey();
Console.Clear();
}
// !!! @@@ WOOOO finally, got a shooter, now the real fun.

// Slogan Selection in one line
//titleCard();

if (shooterChosen != false) 
{
    Console.WriteLine("                        Let's get this game started! Player 1 is the SHOOTER!");
    Console.WriteLine("                                   Press any key to continue...");
    Console.ReadKey();

}
else if (shooterChosen == true)
{
    Console.WriteLine("                        Let's get this game started! Player 2 is the SHOOTER!");
    Console.WriteLine("                                   Press any key to continue...");
    Console.ReadKey();
}
Console.ReadKey();
Console.Clear();
titleCard();
// Now the betting.

Console.WriteLine("\n BETTING RULES ---");
Console.Write("Each player starts with ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("$100 CASH");
Console.ResetColor();
Console.WriteLine("MATCH the SHOOTER's bet to play with them.\n FADE to bet against the SHOOTER.");


Console.WriteLine("\n SHOOTER RULES ---");
Console.WriteLine("Roll 7 or 11 to win\n2, 3, or 12 to lose.\n4, 5, 6, 8, 9, or 10 becomes the POINT \nroll that number again WIN\nroll a 7 LOSE dice and money\nGood luck!\nWhen done reading, press any key to continue...");
Console.ReadKey();
Console.Clear();
scoreCard(); // <---- this isn't working / I did now, good lord.

Console.WriteLine("\nPlayer 1, place your bet! (enter a number)");
// Fresh Bottom , ohhhh yeah


