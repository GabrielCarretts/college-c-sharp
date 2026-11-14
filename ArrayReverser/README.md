# Array Reverser

## English

### Overview

**Array Reverser** is a C# console application developed for Programming Techniques — Lab 4. The program reads 20 integers, validates each input, and generates a second array containing the values in reverse order, while preserving the original array.

### Features

- Reads exactly 20 integers from the console.
- Validates input with `int.TryParse()` and repeats the prompt when an entry is invalid or empty.
- Reverses the array manually using a `for` loop, without using the built-in `Reverse()` method.
- Keeps the original array unchanged.
- Displays both the original and reversed arrays.

### Project structure

```text
ArrayReverser/
├── Program.cs           # Console input, validation, and output
├── ArrayReverser.cs     # Array storage and reversal logic
├── ArrayReverser.csproj # .NET project configuration
└── README.md
```

### How it works

1. `Program.cs` reads and validates 20 integers.
2. An `ArrayReverser` object receives the original array through `SetNumbers(int[])`.
3. `ReverseNumbers()` creates a new array with the same length as the original.
4. A `for` loop copies each element from the opposite end of the original array:

   ```csharp
   int reverseIndex = numbers.Length - 1 - i;
   reverseNumbers[i] = numbers[reverseIndex];
   ```

5. The method returns the new array, and `Program.cs` prints both arrays.

### Requirements and execution

- **.NET 10 SDK**

From the repository root:

```bash
cd ArrayReverser
dotnet run
```

### Example

If the user enters the integers from `1` to `20`, the final output is:

```text
Conteúdo original do array: 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20
Conteúdo do array invertido: 20 19 18 17 16 15 14 13 12 11 10 9 8 7 6 5 4 3 2 1
```

---

## Português (Brasil)

### Visão geral

**Array Reverser** é uma aplicação de console em C# desenvolvida para o Laboratório 4 de Técnicas de Programação. O programa lê 20 números inteiros, valida cada entrada e cria um segundo vetor com os elementos na ordem inversa, preservando o vetor original.

### Funcionalidades

- Lê exatamente 20 números inteiros pelo console.
- Valida as entradas usando `int.TryParse()` e solicita novamente um valor quando a entrada é inválida ou vazia.
- Inverte o vetor manualmente com um laço `for`, sem usar o método pronto `Reverse()`.
- Mantém o vetor original inalterado.
- Exibe os vetores original e invertido.

### Estrutura do projeto

```text
ArrayReverser/
├── Program.cs           # Entrada, validação e saída no console
├── ArrayReverser.cs     # Armazenamento e lógica de inversão
├── ArrayReverser.csproj # Configuração do projeto .NET
└── README.md
```

### Como funciona

1. O `Program.cs` lê e valida 20 números inteiros.
2. Um objeto `ArrayReverser` recebe o vetor original pelo método `SetNumbers(int[])`.
3. O método `ReverseNumbers()` cria um novo vetor com o mesmo tamanho do original.
4. Um laço `for` copia cada valor a partir da posição correspondente no final do vetor original:

   ```csharp
   int reverseIndex = numbers.Length - 1 - i;
   reverseNumbers[i] = numbers[reverseIndex];
   ```

5. O método retorna o novo vetor, e o `Program.cs` exibe os dois resultados.

### Requisitos e execução

- **.NET 10 SDK**

Na raiz do repositório:

```bash
cd ArrayReverser
dotnet run
```

### Exemplo

Se o usuário digitar os números de `1` a `20`, a saída final será:

```text
Conteúdo original do array: 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20
Conteúdo do array invertido: 20 19 18 17 16 15 14 13 12 11 10 9 8 7 6 5 4 3 2 1
```
