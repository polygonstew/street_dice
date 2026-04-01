// lil nasty down there right now.
// var 
Random slogans = new Random();
int topText = slogans.Next(0, 4);
Console.Clear();
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
string askPlayer = "\n                         Are you ready to play? (y/n)";
// string howManyPlayers = "How many players? (1-4)";
string hL = "\n                      Someone pick High or Low! (H/L)";
// int playerCount = 0;

//asking

Console.Write(askPlayer);
string play = Console.ReadLine().ToLower();
if (play == "y") {
        
    
    Console.Clear();
    switch (topText) {case 0: Console.WriteLine(slogan[0]);break;case 1:Console.WriteLine(slogan[1]);break;case 2:Console.WriteLine(slogan[2]);break;case 3:Console.WriteLine(slogan[3]);break;default:Console.WriteLine(slogan[0]);break;}
    
    Console.WriteLine(topText);
    Console.WriteLine(title);   
    Console.WriteLine("                   Welcome to the streets! Let's get you set up!\n");
    Console.Write(hL);
    }
    else if (play == "n") {
        Console.WriteLine("\n                       Maybe next time!.... punk");
        Environment.Exit(0);
    }
    else {
        
        Console.WriteLine("\n                           Please enter 'y' or 'n'.");
    }   
     
// getting sloppy 


// Console.WriteLine(howManyPlayers);
// if YES

bool shooterChosen = false; // Confusing as all get out. I finally maybe have it working, all just to choose the shooter.
string hLC = Console.ReadLine().ToUpper();  // <--- this is always orange swiggles / use  'string?'  and moved it into loop
    
if (hLC == "H")
    {
        hLC = "High";
    }
    else if (hLC == "L")
    {
        hLC = "Low";
    }
    else
    {
        Console.WriteLine("                    Please enter 'H' for High or 'L' for Low."); // this is messing something up
        //continue; // had no clue this was a thing. I think this is looping back to the H/L question
    }
Console.WriteLine($"                Great! {hLC} it is! Now let's see what you will roll...");
Console.ReadKey();
Console.Clear();
switch (topText) {    case 0:        Console.WriteLine(slogan[0]);        break;    case 1:        Console.WriteLine(slogan[1]);        break;    case 2:        Console.WriteLine(slogan[2]);        break;    case 3:        Console.WriteLine(slogan[3]);        break;    default:        Console.WriteLine(slogan[0]);        break;}

Console.WriteLine(topText);
Console.WriteLine(title);
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
switch (topText) {    case 0:        Console.WriteLine(slogan[0]);        break;    case 1:        Console.WriteLine(slogan[1]);        break;    case 2:        Console.WriteLine(slogan[2]);        break;    case 3:        Console.WriteLine(slogan[3]);        break;    default:        Console.WriteLine(slogan[0]);        break;}

Console.WriteLine(topText);
Console.WriteLine(title);
Console.WriteLine("\n--- Player 2 Rolls ---" + "\nNumber to beat is: " + shooter1);
Console.WriteLine("\nPress any key to continue...");
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
switch (topText) {    case 0:        Console.WriteLine(slogan[0]);        break;    case 1:        Console.WriteLine(slogan[1]);        break;    case 2:        Console.WriteLine(slogan[2]);        break;    case 3:        Console.WriteLine(slogan[3]);        break;    default:        Console.WriteLine(slogan[0]);        break;}

Console.WriteLine(topText);
Console.WriteLine(title);
// shooter choice logic // really considering make 'switch'
if (shooter1 == shooter2) 
{
    Console.WriteLine("It's a tie! Roll again!");
}
else if (shooter1 > shooter2 && hLC == "H") 
{
    Console.WriteLine("Player 1 rolled higher! Player 1 is the SHOOTER!");
    shooterChosen = false; // This breaks the loop! I think, I don't know it is looping back to the H/L question.
}
else if (shooter1 < shooter2 && hLC == "L") 
{
    Console.WriteLine("Player 1 rolled lower! Player 1 is the SHOOTER!");
    shooterChosen = false;
}
else if (shooter1 > shooter2 && hLC == "L") 
{
    Console.WriteLine("Player 2 rolled higher! Player 2 is the SHOOTER!");
    shooterChosen = true;
}
else if (shooter1 < shooter2 && hLC == "H") 
{
    Console.WriteLine("Player 2 rolled lower! Player 2 is the SHOOTER!");
    shooterChosen = true;
}
Console.WriteLine("\nPress any key to continue...");
Console.ReadKey();
Console.Clear();

// !!! @@@ WOOOO finally, got a shooter, now the real fun.

// Slogan Selection in one line
switch (topText) {    case 0:        Console.WriteLine(slogan[0]);        break;    case 1:        Console.WriteLine(slogan[1]);        break;    case 2:        Console.WriteLine(slogan[2]);        break;    case 3:        Console.WriteLine(slogan[3]);        break;    default:        Console.WriteLine(slogan[0]);        break;}
Console.WriteLine(topText);
Console.WriteLine(title);

if (shooterChosen != false) 
{
    Console.WriteLine("Let's get this game started! Player 1 is the SHOOTER!");
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();

}
else if (shooterChosen == true)
{
    Console.WriteLine("Let's get this game started! Player 2 is the SHOOTER!");
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}
// Fresh Bottom , ohhhh yeah
