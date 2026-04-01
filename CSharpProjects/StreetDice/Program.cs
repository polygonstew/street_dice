
/*

Console.WriteLine("                     This isn't momma's street corner anymore!");            <---- gave random slogans to show switch
Console.WriteLine("  _________ __                         __    ________  .__             "); 
Console.WriteLine("/   _____//  |________   ____   _____/  |_  \\______ \\ |__| ____  ____  ");
Console.WriteLine("\\_____  \\   __\\\\_  __ \\_/ __ \\_/ __ \\   __\\  |    |  \\|  |/ ___\\/ __ \\ ");
Console.WriteLine(" /       \\|  |  |  | \\/\\  ___/\\  ___/|  |    |    `   \\  \\  \\__\\  ___/ ");
Console.WriteLine("/______  /|__|  |__|     \\___  >\\___  >__|   /_______  /__|\\___  >___  >");
Console.WriteLine("       \\/                    \\/     \\/               \\/        \\/    \\/ ");
Console.WriteLine("                                                                  Street Dice ");
Console.WriteLine("                                                              v0.00000000001a");

!!! - Was going to do that up there, but I think I can do it better with a raw string literal. I didn't know about it until I was looking up how to do multi-line strings, and it seems perfect for this. I can just copy and paste the ascii art in there and it will preserve the formatting, which is exactly what I want. So I'm going to do that instead of a bunch of Console.WriteLine statements.

*/             

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

//title card
var title = """
         _________  __                         __    ________  .__            
        /   _____/ /  |________   ____   _____/  |_  \______ \ |__| ____  ____  
        \_____  \\    __\_  __ \_/ __ \_/ __ \   __\  |    |  \|  |/ ___\/ __ \ 
         /        \|  |  |  | \/\  ___/\  ___/|  |    |    `   \  \  \__\  ___/ 
        /_______  /|__|  |__|    \___  >\___  >__|   /_______  /__|\___  >___  >
                \/                   \/     \/               \/        \/    \/ 

""";

// string topText = "";

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

// Console.WriteLine(topText);
Console.WriteLine(title);

// die 1

switch (roll)
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

//roll 2
//but... can't i put this in a function or something?

switch (roll)
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