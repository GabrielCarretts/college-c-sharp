ArrayAnalyzer analyzer = new ArrayAnalyzer();
analyzer.GenerateNumbers();
var result = analyzer.FindSmallest();
int[] numbers = analyzer.GetNumbers();
Console.Write($"Conteúdo do array: ");
foreach (int number in numbers)
{
    Console.Write($"{number} ");
}
Console.WriteLine("");
Console.WriteLine($"Menor número encontrado: {result.smallest}");
Console.WriteLine($"Índice da primeira ocorrência: {result.smallestIndex}");