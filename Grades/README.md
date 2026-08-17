# C# Student Grade Evaluator

A simple C# console application developed for study purposes. The algorithm prompts for a student's grade, performs basic logical validations, evaluates the status based on the grade, and displays the final detailed values.

## Features
- Receives the student's grade via terminal.
- Validates if the entered value is valid (between 0 and 10).
- Evaluates the grade by applying the following brackets:
  - 9 to 10: **Excelente.**
  - 7 to 8.9: **Bom.**
  - 5 to 6.9: **Recuperação.**
  - 0 to 4.9: **Reprovado.**
- Displays the consolidated and formatted result in the console (grade with two decimal places and the final status).

## Concepts Applied
During the construction of this algorithm, the following C# concepts and programming best practices were applied:
* **Data Input and Output:** Use of `Console.ReadLine()` and `Console.Write()`.
* **Type Conversion (Parsing):** Transforming text into decimals via `decimal.Parse()`.
* **Guard Clauses:** Implementing early returns (`return;`) to validate inputs (values `< 0` or `> 10`) before executing the main logic.
* **Modern Pattern Matching:** Flow control and validation using modern C# logical operators like `or` and relational patterns (`<`, `>`).
* **Switch Expressions:** Clean and concise conditional logic utilizing relational patterns (`>=`, `<=`, `and`) inside a `switch` expression to determine the correct status without repetitive `if/else` blocks.
* **String Interpolation and Formatting:** Clean formatting of text output using the `$""` feature, line breaks (`\n`), and numeric format specifiers (`:F2`) to accurately control decimal places.

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
