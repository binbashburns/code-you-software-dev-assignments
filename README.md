# Code You Software Development (with C#) Assignments

This repository contains C# console application assignments for software development with CodeYou. 

## Project Structure

### Solution File 
- **`code-you-software-dev-assignments.sln`**: Visual Studio solution file that contains all projects in this repository

## Week 1 Projects

#### `week-1-console-writeline/` [[link](https://github.com/binbashburns/code-you-software-dev-assignments/tree/main/week-1-console-writeline)]
A simple console application that demonstrates basic user input/output operations.

**What it does:**
- Prompts the user to enter their name
- Reads the user's input from the console
- Displays a personalized greeting message

**Key concepts covered:**
- `Console.WriteLine()` for output
- `Console.ReadLine()` for input
- String concatenation
- Basic program flow

#### `week-1-guided-project/` [[link](https://github.com/binbashburns/code-you-software-dev-assignments/tree/main/week-1-guided-project)]
A student grade calculator that processes multiple students' assignment scores.

**What it does:**
- Stores grades for 4 students (Sophia, Nicolas, Zahirah, and Jeong)
- Calculates the average score for each student
- Displays results in a formatted table with letter grades

**Key concepts covered:**
- Variable declaration and initialization
- Integer and decimal data types
- Type casting (`(decimal)`)
- Mathematical operations
- Formatted console output with tabs (`\t`)
- Grade calculation logic

## Week 3 Projects

#### `week-3-arrays/` [[link](https://github.com/binbashburns/code-you-software-dev-assignments/tree/main/week-3-arrays)]
A console application that demonstrates array usage and iteration through collections.

**What it does:**
- Declares and initializes a string array with a list of the greatest sodas of all time
- Iterates through the array using a `foreach` loop
- Displays each element in the collection to the console

**Key concepts covered:**
- Array declaration and initialization
- String arrays
- `foreach` loop for iteration
- Working with collections
- Multi-line comments (`/* */`)
- Single-line comments (`//`)

## Week 4 Projects

#### `week-4-loops/` [[link](https://github.com/binbashburns/code-you-software-dev-assignments/tree/main/week-4-loops)]
A comprehensive console application combining arrays, loops, and conditional logic.

**What it does:**
- Initializes a string array with SpongeBob SquarePants characters
- Uses a traditional `for` loop to iterate through the array (not `foreach`)
- Evaluates each character and displays unique information using `if/else if` statements

**Key concepts covered:**
- Array initialization and indexing
- `for` loop with manual index control
- Array `.Length` property
- Conditional statements (`if/else if/else`)
- String comparison and interpolation
- Combining multiple programming concepts

## Supporting Directories

#### `extras/`
Practice exercises and supplementary learning materials covering various C# concepts.

**Projects included:**

- **`bool/`** - Boolean expressions and comparison operators
  - Equality (`==`), inequality (`!=`), greater/less than
  - String comparison with `.Contains()`, `.Trim()`, `.ToLower()`
  
- **`business-rules/`** - Subscription expiration logic with conditional discounts
  - Nested `if/else` statements
  - Random number generation
  - Tiered business logic implementation
  
- **`call-methods/`** - Introduction to calling built-in methods
  - Using `Random.Next()` for random values
  - Basic method invocation
  
- **`branching-logic/`** - Switch statement examples and challenges
  - `switch/case` syntax
  - Stock Keeping Unit (SKU) processing
  - Pattern matching with switch expressions
  
- **`if-else-elseif/`** - Dice game demonstrating conditional logic
  - Multiple conditional checks with `if/else if`
  - Logical operators (`&&`, `||`)
  - Detecting doubles and triples
  
- **`loops/`** - Various loop types and patterns
  - `do/while` loops
  - Hero vs. Monster challenge game
  - User input validation with loops
  
- **`calculate-final-gpa/`** - GPA calculator
  - Variable declaration and initialization
  - Credit hour and grade point calculations
  - Mathematical operations with integers and decimals

## Technical Details

- **Framework:** .NET 9.0
- **Language:** C# 
- **Project Type:** Console Applications
- **IDE Compatibility:** Visual Studio, VS Code, Rider

## Getting Started

### Prerequisites
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download) installed on your machine

### Running the Projects

#### Option 1: Using Command Line
Navigate to the project directory and run:

```bash
# For the console writeline project
cd week-1-console-writeline
dotnet build
dotnet run

# For the guided project
cd week-1-guided-project
dotnet build
dotnet run
```

#### Option 3: Using the Solution
Build and run all projects from the solution root:

```bash
# Build all projects
dotnet build

# Run a specific project
dotnet run --project week-1-console-writeline
dotnet run --project week-1-guided-project
```

## Learning Objectives

These assignments help students understand:

1. **Basic C# Syntax**: Variable declaration, data types, operators
2. **Console I/O**: Reading user input and displaying output
3. **Data Processing**: Performing calculations and data manipulation
4. **Program Structure**: Understanding how C# console applications are organized
5. **Development Workflow**: Building and running .NET applications

##  Notes

- Projects follow standard .NET naming conventions
- Each project is self-contained and can be run independently