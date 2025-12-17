Console.WriteLine("Christmas Gift Suggester 5000");
Console.WriteLine("Because gifting socks is only funny once.\n");

// basic input
Console.Write("What is your friend's first name? ");
string friendName = Console.ReadLine() ?? "";

Console.WriteLine();
Console.WriteLine("What is this friend most into right now?");
Console.WriteLine("1. Marvel movies");
Console.WriteLine("2. Coding");
Console.WriteLine("3. Gamer stuff");
Console.WriteLine("4. Books");
Console.WriteLine("5. Animals");
Console.Write("Type the number and press Enter: ");

string interestChoice = Console.ReadLine() ?? "";

int choiceNumber = 0;
bool parsed = int.TryParse(interestChoice, out choiceNumber);

if (!parsed)
{
	choiceNumber = 0;
}

// turn the menu choice into a simple interest key
string interestKey = "unknown";

if (choiceNumber == 1)
{
	interestKey = "marvel";
}
else if (choiceNumber == 2)
{
	interestKey = "coding";
}
else if (choiceNumber == 3)
{
	interestKey = "gamer";
}
else if (choiceNumber == 4)
{
	interestKey = "books";
}
else if (choiceNumber == 5)
{
	interestKey = "animals";
}

// create an instance of our class
GiftSuggestion suggestion = new GiftSuggestion(friendName, interestKey);

// call a method on the class instance
suggestion.PickGift();

Console.WriteLine();
Console.WriteLine("Suggestion:");
Console.WriteLine(suggestion.GetSummary());

// small checklist using an array and loop
string[] checklist =
{
	"Check if they secretly already own this",
	"Remember to remove the price sticker",
	"Pretend you planned this a long time ago"
};

Console.WriteLine();
Console.WriteLine("Last minute checklist:");

foreach (string item in checklist)
{
	Console.WriteLine("- " + item);
}

