// // simple for, outputs one number per line from 0-9 ascending
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }



// // simple for, outputs one number per line from 10-0 descending
// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine(i);
// }


// // simple for, outputs multiples of 3 (and zero), from 0-9 ascending
// for (int i = 0; i < 10; i += 3)
// {
//     Console.WriteLine(i);
// }



// // stopping for with break statement
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }



// // iterate through an array, in reverse
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }




// // search and replace an element in an array
// // iterate through the array with a for loop, find "David", and replace with "Sammy"
// string[] names = { "Alex", "Eddie", "David", "Michael" };

// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == "David")
//     {
//         names[i] = "Sammy";
//     }
// }

// foreach (var name in names)
// {
//     Console.WriteLine(name);
// }


// FizzBuzz
for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}