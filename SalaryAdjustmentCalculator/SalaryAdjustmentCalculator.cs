Console.Write("Digite o salário: R$ ");
string auxSalarioInicial = Console.ReadLine();
decimal salarioInicial = decimal.Parse(auxSalarioInicial);
if (salarioInicial < 0)
{
    Console.Write("Valor inválido!");
    return;
}

Console.Write("Digite o cargo (1 - gerente | 2 - engenheiro | 3 - técnico | 4 - supervisor): ");
string auxCargo = Console.ReadLine();
char cargo = char.Parse(auxCargo);
decimal percentualAumento = 0;

switch (cargo)
{
case '1':
case '4':
percentualAumento = 0.1m;
break;

case '2':
percentualAumento = 0.2m;
break;

case '3':
percentualAumento = 0.3m;
break;
default:
percentualAumento = 0.4m;
break;
}

decimal aumento = salarioInicial * percentualAumento;
decimal salarioFinal = salarioInicial + aumento;

Console.Write($"\nSalário antigo: R$ {salarioInicial:F2} \nNovo salário: R$ {salarioFinal:F2} \nDiferença: R$ {aumento:F2}");