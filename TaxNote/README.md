# C# Invoice Tax Calculator

A simple C# console application developed for study purposes. The algorithm prompts for an invoice value, performs basic logical validations, calculates the applicable tax based on progressive brackets, and displays the final detailed values.

## Features
- Receives the invoice value via terminal.
- Validates if the entered value is valid (greater than or equal to zero).
- Calculates the tax by applying the following percentages based on the value bracket:
  - Up to R$ 999.99: **2.0%**
  - Up to R$ 2,999.99: **2.5%**
  - Up to R$ 6,999.99: **2.8%**
  - Above R$ 6,999.99: **3.0%**
- Displays the consolidated and formatted result in the console (original value, applied tax percentage, tax amount, and total value).

## Concepts Applied
During the construction of this algorithm, the following C# concepts and programming best practices were applied:
* **Data Input and Output:** Use of `Console.ReadLine()` and `Console.Write()`.
* **Type Conversion (Parsing):** Transforming text into decimals via `decimal.Parse()`.
* **Modern Pattern Matching:** Flow control and validation using modern C# checks (`if (valor is < 0)`).
* **Switch Expressions:** Clean and concise conditional logic utilizing relational patterns (`<=`) inside a `switch` expression to determine the correct tax percentage without repetitive `if/else` blocks.
* **Arithmetic Operations:** Calculating percentages and totals using math operators on `decimal` types.
* **String Interpolation and Formatting:** Clean formatting of text output using the `$""` feature, line breaks (`\n`), and numeric format specifiers (`:F1`, `:F2`) to accurately control decimal places for currency and percentages.

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
