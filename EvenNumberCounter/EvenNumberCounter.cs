public class EvenNumberCounter
{
    public int[] GetEvenNumbers(int[] numbers)
    {
        int[] evenNumbers = numbers.Where(number => number % 2 == 0).ToArray();
        return evenNumbers;
    }
}