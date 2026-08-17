// Carlos Gabriel Leite Carretts //

Console.Write("Informe o nome: ");
string? usuario = Console.ReadLine();
Console.Write("Informe a idade: ");
string auxIdade = Console.ReadLine();
int idade = int.Parse(auxIdade);
Console.Write("O usuário é ativo? (true/false) ");
string auxAtivo = Console.ReadLine();
bool ativo = bool.Parse(auxAtivo);

string mensagem = (usuario, idade, ativo) switch
{
    (null or "", _, _) => "Acesso negado! Usuário inexistente!",
    (_, < 18, _) => "Acesso negado! Usuário é menor de idade!",
    (_, _, false) => "Acesso negado! Usuário não é ativo!",
    _ => "Acesso permitido!"
};

Console.Write($"\n{mensagem}");