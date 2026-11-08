# Random Array Analyzer / Analisador de Array Aleatório

## English

A simple C# console application that generates an array of 30 random integers and analyzes its values.

### Features

- Generates **30 random integers from 0 to 100**, inclusive.
- Displays all values in the array.
- Finds the **smallest value** and the index of its first occurrence.
- Finds the **largest value** and the index of its first occurrence.
- Calculates and displays the average with two decimal places.
- Uses manually implemented loops and comparisons instead of LINQ methods for learning purposes.

### Code structure

- **`Program.cs`** runs the analysis and displays the results in the console.
- **`ArrayAnalyzer.cs`** generates the array and provides methods to retrieve values, find the minimum and maximum with their indices, calculate the sum, and calculate the average.

### How to run

With the .NET SDK installed, open a terminal in the `RandomArray` project directory and run:

```bash
dotnet run
```

---

## Português (Brasil)

Uma aplicação simples de console em C# que gera um array com 30 números inteiros aleatórios e analisa seus valores.

### Funcionalidades

- Gera **30 números inteiros aleatórios de 0 a 100**, incluindo os limites.
- Exibe todos os valores do array.
- Encontra o **menor valor** e o índice de sua primeira ocorrência.
- Encontra o **maior valor** e o índice de sua primeira ocorrência.
- Calcula e exibe a média com duas casas decimais.
- Utiliza laços e comparações implementados manualmente, sem métodos LINQ, para praticar lógica de programação.

### Organização do código

- **`Program.cs`** executa a análise e exibe os resultados no console.
- **`ArrayAnalyzer.cs`** gera o array e disponibiliza métodos para consultar os valores, encontrar o menor e o maior com seus índices, calcular a soma e calcular a média.

### Como executar

Com o SDK do .NET instalado, abra um terminal na pasta do projeto `RandomArray` e execute:

```bash
dotnet run
```
