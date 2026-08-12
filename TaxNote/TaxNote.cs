Console.Write("Digite o valor da nota fiscal: R$ ");
string auxValor = Console.ReadLine();
decimal valor = decimal.Parse(auxValor);
if (valor is < 0)
{
    Console.Write("Valor Inválido!");
    return;
}

decimal percentual = valor switch
{
    <= 999.99m => 0.02m,
    <= 2999.99m => 0.025m,
    <= 6999.99m => 0.028m,
    _ => 0.03m
};

decimal imposto = valor * percentual;
decimal total = valor + imposto;

Console.Write($"\nValor da nota fiscal: R$ {valor:F2} \nPercentual aplicado de imposto: {percentual * 100:F1}% \nValor do imposto: R$ {imposto:F2} \nValor total: R$ {total:F2}");