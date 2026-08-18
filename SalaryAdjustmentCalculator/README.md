# C# Salary Adjustment Calculator

A C# console application designed to calculate and process employee salary increases based on their specific job roles. The program uses classic control flow structures to determine the correct percentage and outputs a detailed financial summary.

## Features
- Prompts the user for the current salary and job role code.
- Blocks invalid (negative) salary inputs instantly.
- Evaluates the job role using a classic `switch/case` structure:
  - **1 (Manager) & 4 (Supervisor):** 10% increase.
  - **2 (Engineer):** 20% increase.
  - **3 (Technician):** 30% increase.
  - **Other roles:** 40% increase.
- Calculates and displays the previous salary, the exact increase amount, and the updated final salary.

## Concepts Applied
During the development of this algorithm, the following C# programming concepts were applied:
* **Data Parsing:** Converting string inputs into precise `decimal` and memory-efficient `char` types.
* **Financial Precision:** Using the `decimal` type with the `m` suffix, which is the industry standard in C# for handling currency and avoiding floating-point rounding errors.
* **Guard Clauses:** Implementing an early `return;` inside an `if` statement to immediately halt execution if the user enters a negative salary.
* **Classic Switch/Case Structure:** Utilizing the traditional `switch`, `case`, `break`, and `default` keywords for strict menu-driven logic.
* **Switch Fall-Through:** Stacking cases (`case '1': case '4':`) to route different inputs to the same execution block, eliminating code duplication (DRY principle - Don't Repeat Yourself).
* **String Interpolation:** Formatting the final financial report using cleanly broken lines (`\n`) and dynamic variables.

## How to Run

Make sure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.

1. Clone this repository or download the main project files.
2. Open the terminal (or your editor's command line tool, such as VS Code) in the folder where the files are located.
3. Run the following command to build and execute the project:
```bash
dotnet run