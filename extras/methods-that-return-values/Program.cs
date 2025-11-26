
// SHOPPING CART CALCULATOR WITH DISCOUNTS
// This program calculates a shopping total with item-specific discounts
// and applies a $5 bonus discount if the total meets a minimum spend threshold

// Global variables (like Python module-level variables)
double total = 0;                    // Running total of all items
double minimumSpend = 30.00;         // Threshold for bonus discount

// Arrays of item prices and their corresponding discount rates (0.30 = 30% off)
double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};       // Item prices
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};       // Discount rates (parallel array)

// MAIN PROGRAM LOGIC (equivalent to Python's if __name__ == "__main__":)
// Loop through each item and calculate discounted price
for (int i = 0; i < items.Length; i++)
{
    // Call our custom function to get the discounted price for item at index i
    total += GetDiscountedPrice(i);
}

// Apply $5 bonus discount if total meets minimum (using ternary operator)
// This is like Python: total -= 5.00 if TotalMeetsMinimum() else 0.00
total -= TotalMeetsMinimum() ? 5.00 : 0.00;

// Display the final total (using string interpolation like Python f-strings)
Console.WriteLine($"Total: ${FormatDecimal(total)}");

// CUSTOM METHODS (like Python functions, but with explicit return types)
// Note: In C#, methods can be defined after they're used (unlike Python)

// Function to calculate discounted price for a specific item
// Parameters: itemIndex (int) - the index of the item in our arrays
// Returns: double - the discounted price
double GetDiscountedPrice(int itemIndex)
{
    // Formula: original_price * (1 - discount_rate)
    // Example: $15.97 * (1 - 0.30) = $15.97 * 0.70 = $11.18
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

// Function to check if total qualifies for bonus discount
// Returns: bool - true if total >= minimum spend, false otherwise
bool TotalMeetsMinimum()
{
    return total >= minimumSpend;
}

// Function to format decimal for display (crude formatting)
// Parameters: input (double) - the number to format
// Returns: string - formatted number as string
string FormatDecimal(double input)
{
    // Convert to string and take first 5 characters (not ideal formatting!)
    return input.ToString().Substring(0, 5);
}




// USD -> VND (Vietnamese) Converter
double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd) 
{
    int rate = 23500;
    return (int) (rate * usd);
}

double VndToUsd(int vnd) 
{
    double rate = 23500;
    return vnd / rate;
}





// Reversing words without string.Reverse
string input = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

string ReverseSentence(string input) 
{
    string result = "";
    string[] words = input.Split(" ");
    foreach(string word in words) 
    {
        result += ReverseWord(word) + " ";
    }
    return result.Trim();
}

string ReverseWord(string word) 
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--) 
    {
        result += word[i];
    }
    return result;
}





// palindromes
string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

Console.WriteLine("Is it a palindrome?");
foreach (string word in words) 
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word) 
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end) 
    {
        if (word[start] != word[end]) 
        {
            return false;
        }
        start++;
        end--;
    }

    return true;
}





// coins
int target = 30;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[,] result = TwoCoins(coins, target);

if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < result.GetLength(0); i++) 
    {
        if (result[i,0] == -1) 
        {
            break;
        }
        Console.WriteLine($"{result[i,0]},{result[i,1]}");
    }
}

int[,] TwoCoins(int[] coins, int target) 
{
    int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++) 
    {
        for (int next = curr + 1; next < coins.Length; next++) 
        {    
            if (coins[curr] + coins[next] == target) 
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0)) 
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0,0] : result;
}





// game
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

bool ShouldPlay() 
{
    string response = Console.ReadLine();
    return response.ToLower().Equals("y");
}

void PlayGame() 
{
    var play = true;

    while (play) {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int GetTarget() 
{
    return random.Next(1, 6);
}

int RollDice() 
{
    return random.Next(1, 7);
}

string WinOrLose(int roll, int target) 
{
    if (roll > target) 
    {
        return "You win!";
    }
    return "You lose!";
}