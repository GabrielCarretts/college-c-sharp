# C# Simple Calculator

A simple C# console application developed for study purposes. The algorithm prompts for two decimal numbers and a mathematical operator, performs basic logical validations, calculates the result, and displays the final value.

## Features
- Receives two numbers and a mathematical operator (+, -, *, /) via terminal.
- Validates if the entered operation symbol is valid.
- Prevents division by zero, displaying an error message and halting the execution.
- Calculates the result using the selected arithmetic operation.
- Displays the consolidated result in the console.

## Concepts Applied
During the construction of this algorithm, the following C# concepts and programming best practices were applied:
* **Data Input and Output:** Use of `Console.ReadLine()` and `Console.Write()`.
* **Type Conversion (Parsing):** Transforming text into decimals and characters via `decimal.Parse()` and `char.Parse()`.
* **Guard Clauses:** Implementing early returns (`return;`) to validate inputs (invalid operators and division by zero) before executing the main logic.
* **Modern Pattern Matching:** Flow control and validation using modern C# checks, such as `is not` and logical `or`.
* **Switch Expressions:** Clean and concise conditional logic utilizing a `switch` expression to execute the correct arithmetic operation without repetitive `case` and `break` blocks.
* **String Interpolation:** Clean formatting of text output using the `$""` feature and line breaks (`\n`).

## How to Run

Make sure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine (specifically .NET 10.0 for this project).

1. Clone this repository or download the main project files.
2. Open the terminal (or your editor's command line tool, such as VS Code) in the folder where the files are located.
3. Run the following command to build and run the project:
```bash
dotnet run
```

---
*Developed by Carlos Gabriel Leite Carretts*