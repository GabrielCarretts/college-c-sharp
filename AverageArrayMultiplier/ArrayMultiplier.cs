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

    public decimal[] MultiplyByAverage()
    {
        decimal average = CalculateAverage();
        decimal[] multipliedNumbers = numbers.Select(number => number * average).ToArray();
        return multipliedNumbers;
    }
}