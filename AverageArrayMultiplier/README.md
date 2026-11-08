# Average Array Multiplier / Multiplicador de Array pela Média

## English

A simple C# console application that reads 10 decimal numbers, calculates their average, and creates a second array by multiplying each original value by that average.

### Features

- Asks the user to enter **10 decimal numbers**.
- Validates each input with `decimal.TryParse()` and repeats the prompt when the input is invalid.
- Stores and displays the values in the first array.
- Calculates the arithmetic mean using LINQ's `Average()` method.
- Creates a second array using `Select()` and `ToArray()`, multiplying each element by the average.
- Displays the second array while keeping the original values unchanged.

### Code structure

- **`Program.cs`** handles user input, validation, and console output.
- **`ArrayMultiplier.cs`** stores the received array, calculates its average, and generates the multiplied array using LINQ.

### How to run

With the .NET SDK installed, open a terminal in the `AverageArrayMultiplier` project directory and run:

```bash
dotnet run
```

---

## Português (Brasil)

Uma aplicação simples de console em C# que lê 10 números decimais, calcula a média e cria um segundo array multiplicando cada valor original por essa média.

### Funcionalidades

- Solicita ao usuário **10 números decimais**.
- Valida cada entrada com `decimal.TryParse()` e solicita novamente o valor quando a entrada é inválida.
- Armazena e exibe os valores no primeiro array.
- Calcula a média aritmética utilizando o método `Average()` do LINQ.
- Cria um segundo array com `Select()` e `ToArray()`, multiplicando cada elemento pela média.
- Exibe o segundo array sem alterar os valores do array original.

### Organização do código

- **`Program.cs`** cuida da entrada de dados, validação e exibição dos resultados no console.
- **`ArrayMultiplier.cs`** armazena o array recebido, calcula sua média e gera o array multiplicado utilizando LINQ.

### Como executar

Com o SDK do .NET instalado, abra um terminal na pasta do projeto `AverageArrayMultiplier` e execute:

```bash
dotnet run
```
