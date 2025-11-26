Console.WriteLine("Thanksgiving Leftover Calculator");
Console.WriteLine("What to do with all of this food....\n");

string[] leftoverFoods = { "Turkey", "Stuffing", "Mashed Potatoes", "Green Bean Casserole", "Cranberry Sauce" };
double[] leftoverPounds = new double[leftoverFoods.Length];


Console.WriteLine("Enter how many pounds of each food you have left:");
for (int i = 0; i < leftoverFoods.Length; i++)
{
    Console.Write($"How many pounds of {leftoverFoods[i]} do you have? ");
    string input = Console.ReadLine();
    
    leftoverPounds[i] = double.Parse(input);
}

Console.WriteLine("\n ################## CALCULATING ################## \n");


for (int i = 0; i < leftoverFoods.Length; i++)
{
    string food = leftoverFoods[i];
    double pounds = leftoverPounds[i];
    
    Console.WriteLine($"Checking {food}: {pounds} pounds remaining");
    
    int mealCount = CalculateMealPortions(pounds);
    
    if (mealCount >= 5)
    {
        Console.WriteLine($"Wow. You have enough {food} for {mealCount} meals. Time to invite the in-laws");
    }
    else if (mealCount >= 2)
    {
        Console.WriteLine($"You've got {mealCount} meals worth of {food}. Time to make some crazy sandwiches");
    }
    else if (mealCount >= 1)
    {
        Console.WriteLine($"Probably just enough {food} for 1 more meal. Unless you're crazy and don't like Thanksgiving leftovers.");
    }
    else
    {
        Console.WriteLine($"Not enough {food} left. Give it to the puppies, I'm sure they'll love it.");
    }
    Console.WriteLine(); 
}

// Method that accepts pounds and returns number of meal portions
static int CalculateMealPortions(double pounds)
{
    const double poundsPerMeal = 0.5;
    int mealPortions = (int)(pounds / poundsPerMeal);
    return mealPortions;
}