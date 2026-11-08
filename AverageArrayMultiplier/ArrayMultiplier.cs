public class ArrayMultiplier
{
    decimal[] numbers = new decimal[10];

    public void SetNumbers(decimal[] numbersReceived)
    {
        numbers = numbersReceived;
    }

    public decimal CalculateAverage()
    {
        decimal average = numbers.Average();
        return average;
    }

    
}