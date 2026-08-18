# C# Number Guessing Game

A simple C# console application developed for study purposes. The algorithm generates a random integer between 0 and 10, prompts the user for a guess, validates the input range, and provides helpful feedback on whether the guess was too high, too low, or correct.

## Features
- Generates a secure random number between 0 and 10 using modern .NET practices.
- Receives the user's guess via terminal.
- Validates if the entered value is within the allowed boundaries (0 to 10).
- Compares the user's guess with the system's generated number using optimized conditional branches.
- Displays friendly feedback guidance ("Too high!", "Too low!", or a congratulatory message).

## Concepts Applied
During the construction of this algorithm, the following C# concepts and programming best practices were applied:
* **Data Input and Output:** Use of `Console.ReadLine()` and `Console.Write()`.
* **Type Conversion (Parsing):** Transforming text input into integers via `int.Parse()`.
* **Modern Guard Clauses:** Implementing early returns (`return;`) using elegant pattern matching (`is < 0 or > 10`) to discard out-of-bounds numbers immediately.
* **Random Number Generation:** Efficiently generating pseudo-random integers using the modern thread-safe `Random.Shared.Next()` API.
* **Traditional Control Flow:** Employing clean `if`, `else if`, and `else` blocks, which represents the most readable and maintainable structural choice for direct, relational comparisons between two scalar variables.
* **String Interpolation:** Formatting dynamic text outputs neatly using the `$""` syntax combined with clean line breaks (`\n`).

## How to Run

Make sure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine (specifically .NET 10.0 for this project).

1. Clone this repository or download the main project files.
2. Open the terminal (or your editor's command line tool, such as VS Code) in the folder where the files are located.
3. Run the following command to build and run the project:
```bash
dotnet run