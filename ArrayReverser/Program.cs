int[] numbers = new int[20];
bool validInput;

for (int i = 0; i < numbers.Length; i++)
{
    do
    {
        Console.Write($"Digite o {1 + i}º número: ");
        if (!int.TryParse(Console.ReadLine(), out int value))
        {
            validInput = false;
            Console.WriteLine("Valor inválido! Tente novamente!");
        }
        else
        {
            validInput = true;
            numbers[i] = value;
        }
    } while (!validInput);
}

ArrayReverser reverser = new ArrayReverser();
reverser.SetNumbers(numbers);
int[] reverseNumbers = reverser.ReverseNumbers();

Console.Write($"Conteúdo original do array: ");
foreach (int number in numbers)
{
    Console.Write($"{number} ");
}
Console.WriteLine();
Console.Write($"Conteúdo do array invertido: ");
foreach (int number in reverseNumbers)
{
    Console.Write($"{number} ");
}