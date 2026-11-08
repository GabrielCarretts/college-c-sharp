public class ArrayAnalyzer
{
    int[] numbers = new int[30];
    Random random = new Random();
    public void GenerateNumbers()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(0, 101);
        }
    }
    public int[] GetNumbers()
    {
        return numbers;
    }
}