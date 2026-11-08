ArrayAnalyzer analyzer = new ArrayAnalyzer();
analyzer.GenerateNumbers();
int[] numbers = analyzer.GetNumbers();
Console.Write($"Conteúdo do array: ");
foreach (int number in numbers)
{
    Console.Write($"{number} ");
}
Console.WriteLine("");