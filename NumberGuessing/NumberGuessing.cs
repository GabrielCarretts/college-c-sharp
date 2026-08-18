// Carlos Gabriel Leite Carretts //
Console.Write("\nDigite um número (0-10): ");
string auxValorUsuario = Console.ReadLine();
int valorUsuario = int.Parse(auxValorUsuario);

if (valorUsuario is < 0 or > 10)
{
    Console.Write($"{valorUsuario}, está fora da faixa de valor permitida!");
    return;
}

int valorSistema = Random.Shared.Next(0, 11);
string resultado;
if (valorUsuario < valorSistema)
{
    resultado = "Errou! Deveria ter digitado um valor maior!";
}
else if (valorUsuario > valorSistema)
{
    resultado = "Errou! Deveria ter digitado um valor menor!";
}
else
{
    resultado = "Parabéns! Você acertou o número!";
}

Console.Write($"\nValor sorteado: {valorSistema} \n{resultado}");