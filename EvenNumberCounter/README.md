# Even Number Counter

## English

### Overview

**Even Number Counter** is a C# console application developed for **Programming Techniques — Lab 5**. The program asks the user how many integers to enter, reads and validates them, then displays the even numbers and their total count.

The project separates console interaction from processing logic and uses **LINQ** to filter the numbers.

### Features

- Lets the user choose the number of integers to enter (`N`).
- Accepts `0` as an option to exit before entering any numbers.
- Rejects invalid or negative values for `N`.
- Validates each integer using `int.TryParse()` and prompts again when an entry is invalid.
- Accepts negative integers and zero as array elements; both may be even.
- Filters even numbers using LINQ's `Where()` and converts the result with `ToArray()`.
- Displays the even numbers with `string.Join()` and counts them with `Length`.
- Displays a message when no even numbers are found.

### Project structure

```text
EvenNumberCounter/
├── Program.cs             # User input, validation, and console output
├── EvenNumberCounter.cs   # LINQ filtering logic
├── EvenNumberCounter.csproj
└── README.md
```

### How it works

1. The user enters `N`, the number of integers to read. Negative or non-integer values are rejected; `0` exits the program.
2. The program creates an `int[]` array with `N` positions and reads each integer with validation.
3. `Program.cs` calls `GetEvenNumbers(numbers)` on an `EvenNumberCounter` object.
4. The method filters numbers for which `number % 2 == 0` using `Where()` and returns a new `int[]`.
5. The application prints the filtered numbers (or a message if none are found) and the count.

### Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

### Run locally

From the repository root:

```bash
cd EvenNumberCounter
dotnet run
```

Or, if you are already inside the `EvenNumberCounter` directory:

```bash
dotnet run
```

### Example

```text
Quantos números deseja digitar (0 para sair): 5
Digite o 1º número: -4
Digite o 2º número: 0
Digite o 3º número: 7
Digite o 4º número: 9
Digite o 5º número: 12
Números pares: -4, 0, 12
Quantidade de números pares: 3
```

### Concepts practiced

C# arrays, loops (`for` and `while`), `int.TryParse()`, methods and classes, LINQ (`Where()` and `ToArray()`), modulo (`%`), `string.Join()`, and separation of responsibilities.

---

## Português (PT-BR)

### Visão geral

**Even Number Counter** é uma aplicação de console em C# desenvolvida para **Técnicas de Programação — Laboratório 5**. O programa solicita quantos números inteiros o usuário deseja informar, realiza a leitura e a validação e, em seguida, exibe os números pares e sua quantidade.

O projeto separa a interação com o usuário da lógica de processamento e utiliza **LINQ** para filtrar os números.

### Funcionalidades

- Permite escolher a quantidade `N` de números inteiros a serem digitados.
- Aceita `0` para encerrar o programa antes de informar os números.
- Rejeita quantidades negativas ou entradas não inteiras.
- Valida cada número com `int.TryParse()` e solicita uma nova entrada quando necessário.
- Aceita números negativos e zero como elementos do array; ambos podem ser pares.
- Filtra os números pares utilizando `Where()` do LINQ e transforma o resultado em array com `ToArray()`.
- Exibe os números pares com `string.Join()` e a quantidade com `Length`.
- Informa quando nenhum número par é encontrado.

### Estrutura do projeto

```text
EvenNumberCounter/
├── Program.cs             # Entrada, validação e saída no console
├── EvenNumberCounter.cs   # Lógica de filtragem com LINQ
├── EvenNumberCounter.csproj
└── README.md
```

### Como funciona

1. O usuário informa `N`, a quantidade de inteiros. Valores negativos ou não inteiros são rejeitados; `0` encerra a aplicação.
2. O programa cria um array `int[]` com `N` posições e lê cada número com validação.
3. O `Program.cs` chama `GetEvenNumbers(numbers)` por meio de um objeto `EvenNumberCounter`.
4. O método filtra os valores que satisfazem `number % 2 == 0` com `Where()` e retorna um novo `int[]`.
5. A aplicação exibe os números pares (ou uma mensagem caso não existam) e a quantidade encontrada.

### Requisitos

- [SDK do .NET 10](https://dotnet.microsoft.com/download/dotnet/10.0)

### Como executar

Na raiz do repositório:

```bash
cd EvenNumberCounter
dotnet run
```

Ou, caso já esteja na pasta `EvenNumberCounter`:

```bash
dotnet run
```

### Exemplo de execução

```text
Quantos números deseja digitar (0 para sair): 5
Digite o 1º número: -4
Digite o 2º número: 0
Digite o 3º número: 7
Digite o 4º número: 9
Digite o 5º número: 12
Números pares: -4, 0, 12
Quantidade de números pares: 3
```

### Conceitos praticados

Arrays em C#, laços (`for` e `while`), `int.TryParse()`, métodos e classes, LINQ (`Where()` e `ToArray()`), operador módulo (`%`), `string.Join()` e separação de responsabilidades.
