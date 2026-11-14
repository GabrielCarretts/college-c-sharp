public class ArrayReverser
{
    int[] numbers = new int[20];
    int[] reverseNumbers = Array.Empty<int>();

    public void SetNumbers(int[] numbersReceived)
    {
        numbers = numbersReceived;
    }

    public int[] ReverseNumbers()
    {
        reverseNumbers = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            int reverseIndex = numbers.Length - 1 - i;
            reverseNumbers[i] = numbers[reverseIndex];
        }
        return reverseNumbers;
    }
}