int quantity;

Console.Write("Quantos números deseja digitar (0 para sair): ");

while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0)
{
    Console.Write("Valor inválido! Digite novamente: ");
}
if (quantity == 0)
{
    return;
}
int[] numbers = new int[quantity];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Digite o {1 + i}º número: ");
    while (!int.TryParse(Console.ReadLine(), out numbers[i]))
    {
        Console.Write("Valor inválido! Digite novamente: ");
    }
}

EvenNumberCounter counter = new EvenNumberCounter();
int[] evenNumbers = counter.GetEvenNumbers(numbers);
if (evenNumbers.Length == 0)
{
    Console.WriteLine("Nenhum número par encontrado.");
}
else
{
    Console.WriteLine($"Números pares: {string.Join(", ", evenNumbers)}");
}
Console.WriteLine($"Quantidade de números pares: {evenNumbers.Length}");