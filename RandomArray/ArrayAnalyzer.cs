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
    public (int smallest, int smallestIndex) FindSmallest()
    {
        int smallest = numbers[0];
        int smallestIndex = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < smallest)
            {
                smallest = numbers[i];
                smallestIndex = i;
            }
        }
        return (smallest, smallestIndex);
    }
}