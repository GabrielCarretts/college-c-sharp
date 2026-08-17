// Carlos Gabriel Leite Carretts //

Console.Write("Digite o primeiro número: ");
string auxN1 = Console.ReadLine();
Console.Write("Selecione a operação (+, -, *, /): ");
string auxOperacao = Console.ReadLine();
Console.Write("Digite o segundo número: ");
string auxN2 = Console.ReadLine();

decimal N1 = decimal.Parse(auxN1);
decimal N2 = decimal.Parse(auxN2);
char operacao = char.Parse(auxOperacao);

if (operacao is not ('+' or '-' or '*' or '/'))
{
    Console.Write("Operação inválida!");
    return;
}

if (operacao is '/' && N2 is 0)
{
    Console.Write("Divisão por 0! Operação inválida!");
    return;
}

decimal resultado = operacao switch
{
    '+' => N1 + N2,
    '-' => N1 - N2,
    '*' => N1 * N2,
    '/' => N1 / N2,
    _ => 0
};

Console.Write($"\nResultado: {resultado}");