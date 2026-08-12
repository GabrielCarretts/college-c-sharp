# C# Age Classifier

A simple C# console application developed for study purposes. The algorithm prompts for the user's name and age, performs basic logical validations, stores the processed data, and classifies the person into age groups.

## Features
- Receives the user's name and age via terminal.
- Validates if the name is not blank and if the age is a positive number.
- Safely stores the user's data in a **Tuple**.
- Classifies the age into the following categories:
  - **Child** (Under 12 years old)
  - **Teenager** (From 12 to 17 years old)
  - **Adult** (From 18 to 59 years old)
  - **Senior** (60 years old or more)
- Displays the consolidated and formatted result in the console.

## Concepts Applied
During the refactoring and construction of this algorithm, the following C# concepts and programming best practices were applied:
* **Data Input and Output:** Use of `Console.ReadLine()` and `Console.Write()`.
* **String Manipulation and Validation:** Application of the `string.IsNullOrWhiteSpace` method to prevent empty inputs.
* **Type Conversion (Parsing):** Transforming text into integers via `int.Parse()`.
* **Data Structuring with Tuples:** Grouping multiple logical variables using the concise syntax `(type1 name1, type2 name2)`.
* **Conditional Structures and Pattern Matching:** Flow control (logical filtering) using `if/else` blocks combined with modern C# checks (`is <`, `is <=`).
* **DRY Principle (Don't Repeat Yourself):** Optimizing the presentation logic by isolating the dynamic information in the `classificacao` variable, avoiding unnecessary repetition of print commands.
* **String Interpolation:** Clean formatting of text output using the `$""` feature and line breaks (`\n`).

## How to Run

Make sure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine (.NET 6 or higher recommended).

1. Clone this repository or download the main file (`Program.cs`).
2. Open the terminal (or your editor's command line tool, such as VS Code) in the folder where the file is located.
3. Run the following command to build and run the project:
```bash
dotnet run
```

---
*Developed by Carlos Gabriel Leite Carretts*