// Week 4 Deliverables
// For this week, we're going to create a console application that demonstrates everything we have learned since the beginning of the course. To do this, you will create a new C# console application that does the following:
// - Initializes and adds values to an array.
// - Iterates over those values using a `for` loop. Try not to use the ForEach loop. This will give you a better understanding of the functionality a ForEach loop handles for you automatically.
// - Evaluates each of the values in the array and manipulates those values using a condition like `if` or `switch`.

// Initialize and add values to an array
string[] characters = { "SpongeBob", "Patrick", "Sandy", "Mr. Krabs", "Squidward", "Gary" };

// Iterate over those values using a 'for' loop
for (int i = 0; i < characters.Length; i++)
{
    string character = characters[i];
    
    // Evaluate each of the values in the array and manipulate those values using a condition like 'if' or 'switch'
    if (character == "SpongeBob")
    {
        Console.WriteLine($"{character} lives in a pineapple, under the sea");
    }
    else if (character == "Patrick")
    {
        Console.WriteLine($"{character} is SpongeBob's best friend and lives under a rock");
    }
    else if (character == "Sandy")
    {
        Console.WriteLine($"{character} is from Texas, and you don't mess with Texas");
    }
    else if (character == "Mr. Krabs")
    {
        Console.WriteLine($"{character} likes money-money-money");
    }
    else if (character == "Squidward")
    {
        Console.WriteLine($"{character} secretly loves Krabby Pattys, and they went straight to his thighs");
    }
    else if (character == "Gary")
    {
        Console.WriteLine($"{character} is SpongeBob's pet snail... Meow");
    }
    else
    {
        Console.WriteLine($"{character} is a character from Bikini Bottom!");
    }
}