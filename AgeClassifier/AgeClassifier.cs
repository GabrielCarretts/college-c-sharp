// Carlos Gabriel Leite Carretts //

Console.Write("Digite o seu nome: ");
string nome = Console.ReadLine();
if (string.IsNullOrWhiteSpace(nome))
{
    Console.Write("Nome inválido!");
    return;
}

Console.Write("Digite a sua idade: ");
string auxIdade = Console.ReadLine();
int idade = int.Parse(auxIdade);
if (idade is < 0)
{
    Console.Write("Idade Inválida!");
    return;
}

(string nome, int idade) pessoa = (nome, idade);
string classificacao = "";

if (pessoa.idade is < 12)
{
    classificacao = "Criança.";
}
else if (pessoa.idade is <= 17)
{
    classificacao = "Adolescente.";
}
else if (pessoa.idade is <= 59)
{
    classificacao = "Adulto.";
}
else
{
    classificacao = "Idoso.";
}

Console.Write($"\nNome: {pessoa.nome} \nIdade: {pessoa.idade} \nClassificação: {classificacao}");