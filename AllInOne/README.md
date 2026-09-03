# AllInOne

A modular C# console application consolidating multiple programming logic exercises into a single, interactive menu. Developed as a practical study project to apply Clean Code principles, focusing on the strict separation of responsibilities between user interface flow and pure business logic.

## Features

The application features an interactive loop menu allowing users to navigate through 9 different utilities and algorithms:

1. **Caesar Cipher (String):** Encrypts plain text using a specified step/shift via basic string concatenation.
2. **Caesar Decipher (String):** Decrypts ciphered text using `char` array manipulation.
3. **Caesar Cipher (StringBuilder):** Optimized encryption using the `StringBuilder` class for better memory allocation.
4. **Caesar Decipher (StringBuilder):** Optimized decryption using `StringBuilder`.
5. **Age Classification:** Classifies a person (Child, Teenager, Adult, Senior) based on their input age using C# pattern matching.
6. **Number Guessing Game:** An interactive loop where the user tries to guess a system-generated number (0-99), receiving "higher" or "lower" hints.
7. **Collatz Conjecture:** Calculates and displays the mathematical sequence for the Collatz Conjecture (the 3x + 1 problem).
8. **Tax Calculation:** Calculates the applicable tax percentage, tax amount, and total value based on progressive invoice brackets.
9. **Grade Classification:** Evaluates an academic grade (0 to 10) and returns the student's status (Excellent, Good, Recovery, Failed) using relational patterns.

## Architecture & Best Practices

During the development of this project, extensive refactoring was applied to improve code maintainability and readability:
- **Separation of Concerns:** Each exercise is strictly divided into a `MenuX()` method (handling Console I/O and user interaction) and a pure logic method (handling data processing and math).
- **Modern C# Features:** Replaced legacy conditional blocks with concise C# `switch` expressions and relational patterns.
- **Modular Routing:** The main `Program` constructor acts purely as a clean, easily readable navigation index, avoiding the "Fat Controller" anti-pattern.

## Tech Stack
- **Language:** C# (.NET 10.0)
- **Environment:** Console Application (Implicit Usings disabled)

## 👨‍💻 Author
**Carlos Gabriel Leite Carretts**
