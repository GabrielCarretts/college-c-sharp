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

    public (int largest, int largestIndex) FindLargest()
    {
        int largest = numbers[0];
        int largestIndex = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
                largestIndex = i;
            }
        }
        return (largest, largestIndex);
    }

    public double Sum()
    {
        double sum = default;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    public double CalculateAverage()
    {
        double sum = Sum();
        double average = sum / numbers.Length;
        return average;
    }
}