MediaNotas calculadora = new MediaNotas();
int n;
bool entradaValida;
do
{
    Console.Write($"Digite a quantidade de notas: ");
    if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
    {
        entradaValida = false;
        Console.WriteLine("Valor inválido!");
    }
    else
    {
        entradaValida = true;
    }
} while (!entradaValida);

decimal[] notas = new decimal[n];

for (int i = 0; i < notas.Length; i++)
{
    do
    {
        Console.Write($"Digite a {1 + i}ª nota: ");
        if (!decimal.TryParse(Console.ReadLine(), out notas[i]) || notas[i] < 0 || notas[i] > 10)
        {
            entradaValida = false;
            Console.WriteLine("Valor inválido! Tente Novamente!");
        }
        else
        {
            entradaValida = true;
        }
    } while (!entradaValida);
}

calculadora.DefinirNotas(notas);
decimal soma = calculadora.SomarNotas();
decimal media = calculadora.CalcularMedia(soma);
Console.WriteLine($"A soma das notas é: {soma:F2}");
Console.WriteLine($"A média das notas é: {media:F2}");