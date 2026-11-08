ArrayAnalyzer analyzer = new ArrayAnalyzer();
analyzer.GenerateNumbers();
var smallestResult = analyzer.FindSmallest();
var largestResult = analyzer.FindLargest();
var average = analyzer.CalculateAverage();
int[] numbers = analyzer.GetNumbers();
Console.Write($"Conteúdo do array: ");
foreach (int number in numbers)
{
    Console.Write($"{number} ");
}
Console.WriteLine("");
Console.WriteLine($"Menor número encontrado: {smallestResult.smallest}");
Console.WriteLine($"Índice da primeira ocorrência: {smallestResult.smallestIndex}");
Console.WriteLine($"Maior número encontrado: {largestResult.largest}");
Console.WriteLine($"Índice da primeira ocorrência: {largestResult.largestIndex}");
Console.WriteLine($"Valor médio do array: {average:F2}");
