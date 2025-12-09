Console.WriteLine("Christmas Gift Exchange Game");
Console.WriteLine("Welcome to the simple gift exchange.\n");

string[] gifts =
{
	"A pair of fuzzy socks",
	"A retro game cartridge",
	"A mystery sci-fi book",
	"A tiny desktop Christmas tree",
	"A pack of fancy pens"
};

Console.WriteLine("How many people are in the gift exchange?");
Console.Write("Enter a whole number between 1 and 20: ");

// Store user input in a string variable
string userInput = Console.ReadLine() ?? string.Empty;
int participantCount = 0;

try
{
	// Use Parse() method to convert string to int
	participantCount = int.Parse(userInput);

	if (participantCount < 1 || participantCount > 20)
	{
		Console.WriteLine("\nThat number is outside the allowed range.");
	}
	else
	{
		//arrays, Random, and indexing
		Random random = new Random();
		int giftIndex = random.Next(gifts.Length);
		string assignedGift = gifts[giftIndex];

		Console.WriteLine($"\nYou are participant number {participantCount}.");
		Console.WriteLine($"Your randomly assigned gift is: {assignedGift}");

		if (giftIndex == 0)
		{
			Console.WriteLine("This is the cozy option. Good for cold evenings.");
		}
		else if (giftIndex == 1)
		{
			Console.WriteLine("A little blast from the past for your collection.");
		}
		else if (giftIndex == 2)
		{
			Console.WriteLine("You get a story. Perfect for a quiet night.");
		}
		else if (giftIndex == 3)
		{
			Console.WriteLine("Now your desk can be slightly more festive.");
		}
		else
		{
			Console.WriteLine("This is the practical choice for work or study.");
		}
	}
}
catch (FormatException)
{
	// Handle invalid input with try/catch
	Console.WriteLine("\nThat was not a valid whole number.");
}
catch (OverflowException)
{
	// Handle numbers that are outside the valid range for int
	Console.WriteLine("\nThe number entered was too large or too small.");
}
finally
{
	Console.WriteLine("\nGift exchange complete.");
}
