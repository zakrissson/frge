using System;

//string name = "micke";
//string question1 ="who a sussy baka?";

//int points = 0;
//int hp;
//int xp;

//points = points + 1;
//points = points + 1;
//points+= 7;
//points++;(samma sak som +1 poäng)

//Console.WriteLine(name + name);
//Console.WriteLine(points + 50);
//Console.ReadLine();

string answer1 = "";
string answer2 = "";
string answer3 = "";
int points = 0;
points = points +1;
points ++;

Console.WriteLine("question 1");
Console.WriteLine("who a sussy baka?");
Console.WriteLine("eren yeager, danny devito or gojo?");
answer1 = Console.ReadLine();

if (answer1 == "eren yeager")
{
    Console.WriteLine("mm yes");
    Console.WriteLine("u right");
    points ++;
}

if (answer1 == "danny devito" || answer1 == "gojo")
{
    Console.WriteLine("no u");
}

while (answer1 != "eren yeager" && answer1 != "danny devito" && answer1 != "gojo")
{
    Console.WriteLine("just answer u shithead");
    answer1 = Console.ReadLine();
}

Console.WriteLine("question 2");
Console.WriteLine("who unalive?");
Console.WriteLine("florida man, toy story 5 or will to live?");
answer2 = Console.ReadLine();

if (answer2 == "will to live")
{
    Console.WriteLine("ye u ded");
    Console.WriteLine("congrats fucker");
    points++;
}

if (answer2 == "florida man" || answer2 == "toy story 5")
{
    Console.WriteLine("stupid cunt");
}

while (answer2 != "florida man" && answer2 != "toy story 5" && answer2 != "will to live")
{
    Console.WriteLine("just answer twat");
    answer2 = Console.ReadLine();
}

Console.WriteLine("question 3");
Console.WriteLine("why hamster die?");
Console.WriteLine("choked on a capri sun straw, sneezed or breathed?");
answer3 = Console.ReadLine();

if (answer3 == "choked on a capri sun")
{
    Console.WriteLine("theyre stupid fucks i know");
    Console.WriteLine("oh well");
    points++;
}

if (answer3 == "sneezed" || answer3 == "breathed")
{
    Console.WriteLine("u dont know biology u stupid fuck?");
}
Console.ReadLine();

while (answer3 != "choked on a capri sun" && answer3 != "sneezed" && answer3 != "breathed")
{
    Console.WriteLine("just answer the fucking hamster question");
    answer3 = Console.ReadLine();
}