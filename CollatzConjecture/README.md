# C# Collatz Conjecture Sequence

A simple C# console application developed for study purposes. The algorithm prompts for an initial integer value, performs mathematical calculations based on the Collatz Conjecture (3x + 1), and displays the full sequence until the value reaches 1.

## Features
- Receives a starting integer number via terminal.
- Calculates the sequence dynamically by dividing even numbers by 2, and multiplying odd numbers by 3 and adding 1.
- Formats the visual output neatly by placing arrows (`->`) between the steps.
- Halts the execution and breaks the line correctly when the sequence reaches the final value of 1.

## Concepts Applied
During the construction of this algorithm, the following C# concepts and programming best practices were applied:
* **Data Input and Output:** Use of `Console.ReadLine()` and `Console.Write()`.
* **Type Conversion (Parsing):** Transforming text into integers via `int.Parse()`.
* **Loop Control Flow:** Implementing a `while` loop to maintain execution until the sequence reaches the target condition (`y != 1`).
* **Ternary Operators:** Clean and concise conditional logic utilizing a `? :` expression to execute the correct arithmetic operation based on mathematical parity (`x % 2 == 0`) without repetitive `if/else` blocks.
* **String Interpolation:** Clean formatting of text output using the `$""` feature and line breaks (`\n`).

## How to Run

Make sure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine (specifically .NET 10.0 for this project).

1. Clone this repository or download the main project files.
2. Open the terminal (or your editor's command line tool, such as VS Code) in the folder where the files are located.
3. Run the following command to build and run the project:

```bash
dotnet run
```
Developed by Carlos Gabriel Leite Carretts