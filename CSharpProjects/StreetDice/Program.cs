using System;

int p1cash = 100;
int p2cash = 100;
int p1PlaceBet = 0;
int p2PlaceBet = 0;
string matchFade = "";
bool shooterChosen = false;
string hLC = "";
string hLC2 = "";
int shooter1 = 0;
int shooter2 = 0;
Random dice = new Random();

Console.Clear();
titleCard();
while (true)
{
    Console.Write("\n                         Are you ready to play? (y/n) ");
    string play = (Console.ReadLine() ?? "").ToLower();
    
    if (play == "y")
    {
        Console.Clear();
        titleCard();
        Console.WriteLine("                   Welcome to the streets! Let's get you set up!");
        Console.Write("\n                      Player 1 pick High or Low! (H/L) ");
        break;
    }
    else if (play == "n")
    {
        Console.WriteLine("\n                         \x1b[31m Maybe next time!.... punk\x1b[0m");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("\n                           Please enter 'y' or 'n'.");
    }
}

while (true)
{
    hLC = (Console.ReadLine() ?? "").ToUpper();
    
    if (hLC == "H")
    {
        hLC2 = "\x1b[33mHigh\x1b[0m";
        break;
    }
    else if (hLC == "L")
    {
        hLC2 = "\x1b[34mLow\x1b[0m";
        break;
    }
    else
    {
        Console.WriteLine("                    Please enter '\x1b[33mH\x1b[0m' for High or '\x1b[34mL\x1b[0m' for Low.");
    }
}

Console.Clear();
titleCard();
Console.WriteLine($"                Great! {hLC2} it is! Now let's see what you will roll...");

while (true)
{
    Console.WriteLine("\n--- Player 1 Rolls ---");
    int p1Roll1 = dice.Next(1, 7);
    int p1Roll2 = dice.Next(1, 7);
    RollDie(p1Roll1);
    RollDie(p1Roll2);
    shooter1 = p1Roll1 + p1Roll2;
    Console.WriteLine($"Player 1 rolled a total of: {shooter1}");
    
    Console.WriteLine("\nPress any key to roll for Player 2...");
    Console.ReadKey();
    Console.WriteLine();

    int p2Roll1 = dice.Next(1, 7);
    int p2Roll2 = dice.Next(1, 7);
    RollDie(p2Roll1);
    RollDie(p2Roll2);
    shooter2 = p2Roll1 + p2Roll2;
    Console.WriteLine($"Player 2 rolled a total of: {shooter2}\n");
    Console.ReadKey();

    if (shooter1 == shooter2)
    {
        Console.WriteLine("                            It's a tie! Roll again!");
        Console.WriteLine("\nPress any key to REROLL...");
        Console.ReadKey();
        Console.Clear();
        titleCard();
    }
    else if (shooter1 > shooter2 && hLC == "H")
    {
        Console.Clear();
        titleCard();
        Console.WriteLine("                   Player 1 rolled lower! Player 1 is the SHOOTER!");    // these were set up backwards | FIXED
        shooterChosen = false;
        break;
    }
    else if (shooter1 < shooter2 && hLC == "L")
    {
        Console.Clear();
        titleCard();
        Console.WriteLine("                   Player 1 rolled higher! Player 1 is the SHOOTER!");
        shooterChosen = false;
        break;
    }
    else if (shooter1 > shooter2 && hLC == "L")
    {
        Console.Clear();
        titleCard();
        Console.WriteLine("                   Player 2 rolled lower! Player 2 is the SHOOTER!");
        shooterChosen = true;
        break;
    }
    else if (shooter1 < shooter2 && hLC == "H")
    {
        Console.Clear();
        titleCard();
        Console.WriteLine("                   Player 2 rolled higher! Player 2 is the SHOOTER!");
        shooterChosen = true;
        break;
    }
}

Console.Write("\n                         Press any key to continue...");
Console.ReadKey();
Console.Clear();
titleCard();

if (shooterChosen == false)
{
    Console.WriteLine("                  Let's get this game started! Player 1 Get Ready!");
}
else
{
    Console.WriteLine("                  Let's get this game started! Player 2 Get Ready!");
}
Console.Write("                             Press any key to continue...");
Console.ReadKey();
Console.Clear();
titleCard();

Console.WriteLine("\n BETTING RULES ---");
Console.Write("Each player starts with ");
Console.WriteLine("\x1b[33m$\x1b[32m100\x1b[0m CASH to start with.");
Console.WriteLine("MATCH the SHOOTER's bet to play with them.\nFADE to bet against the SHOOTER."); // took out the \x1b[XXm]

Console.WriteLine("\n \x1b[31m!!\x1b[0m SHOOTER RULES ---");
Console.WriteLine("Roll \x1b[32m7\x1b[0m or \x1b[32m11\x1b[0m to win\n\x1b[33m2\x1b[0m, \x1b[33m3\x1b[0m, or \x1b[33m12\x1b[0m to lose.\n\x1b[31m4, 5, 6, 8, 9, or 10\x1b[0m becomes the \x1b[34mPOINT\x1b[0m \nroll that number again \x1b[32mWIN\x1b[0m\nroll a \x1b[33m7\x1b[0m \x1b[31mLOSE\x1b[0m dice and money\nGood luck!\nWhen done reading, press any key to continue...");
Console.ReadKey();


while (p1cash > 0 && p2cash > 0)
{
    Console.Clear();
    titleCard();
    Console.WriteLine("\n --- NEW ROUND ---");

    BettingPhase();

    p1cash = p1cash - p1PlaceBet;
    p2cash = p2cash - p2PlaceBet;
    int thePot = p1PlaceBet + p2PlaceBet;

    Console.Clear();
    scoreCard(thePot, p1cash, p2cash, matchFade, p1PlaceBet, p2PlaceBet);

    CrapsPhase(thePot);

    Console.WriteLine("\nRound over! Press any key for the next round...");
    Console.ReadKey();
}


Console.Clear();
if (p1cash <= 0)
{
    Console.WriteLine("\n\x1b[31mPlayer 1 is BROKE! Player 2 rules the streets!\x1b[0m");
}
else
{
    Console.WriteLine("\n\x1b[31mPlayer 2 is BROKE! Player 1 rules the streets!\x1b[0m");
}





void titleCard()
{
    Random slogans = new Random();
    int topText = slogans.Next(0, 4);
    string slogan1 = "                       \x1b[36mThis isn't Momma's street corner anymore!\x1b[0m";
    string slogan2 = "                        \x1b[36mbetter look nice when your playing...\x1b[0m";
    string slogan3 = "                         \x1b[36m...you gonna die twice and become...\x1b[0m";
    string slogan4 = "                       \x1b[36mtoday you could be a street dice legend!\x1b[0m";
    var slogan = new string[] { slogan1, slogan2, slogan3, slogan4 };

    switch (topText)
    {
        case 0: Console.WriteLine(slogan[0]); break;
        case 1: Console.WriteLine(slogan[1]); break;
        case 2: Console.WriteLine(slogan[2]); break;
        case 3: Console.WriteLine(slogan[3]); break;
        default: Console.WriteLine(slogan[0]); break;
    }

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
}

void scoreCard(int thePot, int p1c, int p2c, string mF, int p1B, int p2B)
{
    Console.ForegroundColor = ConsoleColor.Green;
    string scoreC = $"""
        /$$   
      /$$$$$$                 {$"\x1b[31mPot: \x1b[33m$\x1b[32m{thePot}"}
     /$$__  $$          {$"\x1b[0m-----------------\x1b[32m"}
    | $$  \__/         {$"\x1b[0m| Player 1: \x1b[33m$\x1b[32m{p1c}"}  |
    |  $$$$$$          {$"\x1b[0m| Player 2: \x1b[33m$\x1b[32m{p2c}"}  |
     \____  $$          {$"\x1b[0m-----------------\x1b[32m"}
     /$$  \ $$           {$"\x1b[0mChose to: \x1b[0m{mF}\x1b[32m"}
    |  $$$$$$/          {$"\x1b[0mPlayer 1 Bet: \x1b[33m$\x1b[32m{p1B}"}
     \_  $$_/           {$"\x1b[0mPlayer 2 Bet: \x1b[33m$\x1b[32m{p2B}"}
       \__/   

    """;
    Console.Write(scoreC);
    Console.ResetColor();
}

void RollDie(int r)  // usinf 'r' is still kinda hard to grasp
{
    string[] dieLines = new string[5];

    // FINALLY i get some clean setup dice.
    switch (r)
    {
        case 1: dieLines = new string[] { " ------- ", "|       |", "|   o   |", "|       |", " ------- " }; break;
        case 2: dieLines = new string[] { " ------- ", "|   o   |", "|       |", "|   o   |", " ------- " }; break;
        case 3: dieLines = new string[] { " ------- ", "| o     |", "|   o   |", "|     o |", " ------- " }; break;
        case 4: dieLines = new string[] { " ------- ", "| o   o |", "|       |", "| o   o |", " ------- " }; break;
        case 5: dieLines = new string[] { " ------- ", "| o   o |", "|   o   |", "| o   o |", " ------- " }; break;
        case 6: dieLines = new string[] { " ------- ", "| o   o |", "| o   o |", "| o   o |", " ------- " }; break;
    }

    // these are hard to crack
    foreach (string line in dieLines)
    {
        // color switch for the dice to keep bleeding off
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write(line);
        Console.ResetColor();
        Console.WriteLine(); 
    }
}

void BettingPhase()
{
    Console.WriteLine("\nPlayer 1, place your bet! (enter a number)");
    while (true)
    {
        string p1BetInput = Console.ReadLine() ?? "";
        if (int.TryParse(p1BetInput, out p1PlaceBet) && p1PlaceBet > 0 && p1PlaceBet <= p1cash)
        {
            break;
        }
        Console.WriteLine($"\x1b[32mPlease enter a valid bet amount between 1 and {p1cash}.\x1b[0m");
    }
    
    Console.WriteLine($"Player 1 has placed a bet of $\x1b[33m{p1PlaceBet}\x1b[0m.");
    Console.WriteLine("\nAny key for Player 2...");
    Console.ReadKey();

    while (true)
    {
        Console.WriteLine("\nPlayer 2, will you MATCH or FADE Player 1's bet? [M/F]");
        string p2BetInput = (Console.ReadLine() ?? "").ToUpper();
        
        if (p2BetInput == "M")
        {
            matchFade = "MATCH";
            p2PlaceBet = p1PlaceBet;
            
            if (p2PlaceBet > p2cash) 
            {
                Console.WriteLine("\x1b[31mYou don't have enough to MATCH! Defaulting to ALL IN.\x1b[0m");
                p2PlaceBet = p2cash;
            }
            Console.WriteLine($"\nPlayer 2, MATCH bet! {p2PlaceBet} it is!");
            break;
        }
        else if (p2BetInput == "F")
        {
            matchFade = "FADE";
            Console.WriteLine("\nPlayer 2, place your FADE bet! (enter a number)");
            string p2FadeInput = Console.ReadLine() ?? "";
            
            if (int.TryParse(p2FadeInput, out p2PlaceBet) && p2PlaceBet > 0 && p2PlaceBet <= p2cash)
            {
                Console.WriteLine($"\nPlayer 2, FADE bet placed for $\x1b[33m{p2PlaceBet}\x1b[0m.");
                break;
            }
            Console.WriteLine($"\x1b[32mPlease enter a valid bet amount between 1 and {p2cash}.\x1b[0m");
        }
        else
        {
            Console.WriteLine("\x1b[32mPlease enter 'M' or 'F'.\x1b[0m");
        }
    }
    Console.ReadKey();
}

void CrapsPhase(int potAmount)
{
    Console.WriteLine("\n--- THE COMEOUT ROLL ---");
    Console.WriteLine("Press any key to roll the dice...");
    Console.ReadKey();

    int d1 = dice.Next(1, 7);
    int d2 = dice.Next(1, 7);
    RollDie(d1);
    RollDie(d2);
    int total = d1 + d2;
    Console.WriteLine($"Shooter rolled a {total}!");

    if (total == 7 || total == 11)
    {
        Console.WriteLine("\x1b[32mNATURAL! Shooter WINS!\x1b[0m");
        Payout(shooterChosen, potAmount);
    }
    else if (total == 2 || total == 3 || total == 12)
    {
        Console.WriteLine("\x1b[31mCRAPS! Shooter LOSES!\x1b[0m");
        Payout(!shooterChosen, potAmount); 
    }
    else
    {
        int point = total;
        Console.WriteLine($"\x1b[34mThe POINT is now {point}!\x1b[0m Shooter must roll {point} again before a 7.");
        
        while (true)
        {
            Console.WriteLine("\nPress any key to roll...");
            Console.ReadKey();
            d1 = dice.Next(1, 7);
            d2 = dice.Next(1, 7);
            RollDie(d1);
            RollDie(d2);
            int nextRoll = d1 + d2;
            Console.WriteLine($"Shooter rolled a {nextRoll}...");

            if (nextRoll == point)
            {
                Console.WriteLine("\x1b[32mHIT THE POINT! Shooter WINS!\x1b[0m");
                Payout(shooterChosen, potAmount);
                break;
            }
            else if (nextRoll == 7)
            {
                Console.WriteLine("\x1b[31mSEVEN OUT! Shooter LOSES!\x1b[0m");
                Payout(!shooterChosen, potAmount);
                break;
            }
        }
    }
}

void Payout(bool player2Won, int potAmount)
{
    if (player2Won == false) 
    {
        Console.WriteLine($"Player 1 takes the pot of ${potAmount}!");
        p1cash += potAmount;
    }
    else 
    {
        Console.WriteLine($"Player 2 takes the pot of ${potAmount}!");
        p2cash += potAmount;
    }
}

/*  Notes:
- Keeping the scoreboard up instead of the title card | FIXED
- Added a payout function to clean up the code and make it more readable | FIXED
- Need to add a replay option at the end of the game | NOT ADDED YET
This is the function I was thinking of the the replay static void 

Replay(){
    Console.WriteLine("\nWould you like to play again? (y/n)");
    string replayInput = (Console.ReadLine() ?? "").ToLower();
    
    if (replayInput == "y")
    {
        p1cash = 100;
        p2cash = 100;
        p1PlaceBet = 0;
        p2PlaceBet = 0;
        matchFade = "";
        shooterChosen = false;
        hLC = "";
        hLC2 = "";
        shooter1 = 0;
        shooter2 = 0;
        Console.Clear();
        titleCard();
    }
    else if (replayInput == "n")
    {
        Console.WriteLine("\nThanks for playing! See you next time!");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("\nPlease enter 'y' or 'n'.");
    }
}

*/ 
