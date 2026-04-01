// var // nice and clean
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


int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
static void RollDie(int roll1)
{
    switch (roll1)
    {
        case 1:
            Console.WriteLine(" ------- \n|       |\n|   o   |\n|       |\n ------- ");
            break;
        case 2:
            Console.WriteLine(" ------- \n|   o   |\n|       |\n|   o   |\n ------- ");
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
static void RollDie2(int roll2)
{
switch (roll2)
    {
        case 1:
            Console.WriteLine(" ------- \n|       |\n|   o   |\n|       |\n ------- ");
            break;
        case 2:
            Console.WriteLine(" ------- \n|   o   |\n|       |\n|   o   |\n ------- ");
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

RollDie(roll1, roll2);
Console.Write(roll1);
Console.WriteLine(roll2);
// nice and clean
// i'm getting double rolls for some reason
// going to use VSCode's Source Control for the first time, in this project.