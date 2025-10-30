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

## Supporting Directories

#### `extras/`
Currently empty - reserved for additional course materials or supplementary exercises.

### Build Output Directories
Each project contains standard .NET build artifacts:
- **`bin/`** - Compiled executable files and dependencies
- **`obj/`** - Intermediate build files and project metadata

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