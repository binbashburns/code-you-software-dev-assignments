Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

Console.WriteLine($"Your final total is: {total}");

if (total >= 16)
{
    Console.WriteLine("You win a Baja Blast!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a Surge!");
}
else if (total == 7)
{
    Console.WriteLine("You win a Mountain Dew Game Fuel!");
}
else
{
    Console.WriteLine("You win a Bepis!");
}