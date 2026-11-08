decimal[] numbers = new decimal[3];
bool validInput;

for (int i = 0; i < numbers.Length; i++)
{
    do
    {
        Console.Write($"Digite o {1 + i}º número: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal value))
        {
            validInput = false;
            Console.WriteLine("Valor inválido! Tente novamente!");
        }
        else
        {
            numbers[i] = value;
            validInput = true;
        }
    } while (!validInput);
}

Console.Write($"Conteúdo do 1º array: ");
foreach (decimal number in numbers)
{
    Console.Write($"{number} ");
}

ArrayMultiplier multiplier = new ArrayMultiplier();
multiplier.SetNumbers(numbers);
decimal average = multiplier.CalculateAverage();

Console.WriteLine("");
Console.WriteLine($"Média: {average:F2}");