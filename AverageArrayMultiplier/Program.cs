decimal[] numbers = new decimal[10];
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

ArrayMultiplier multiplier = new ArrayMultiplier();
multiplier.SetNumbers(numbers);