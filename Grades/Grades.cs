// Carlos Gabriel Leite Carretts //

Console.Write("Digite a nota: ");
string auxNota = Console.ReadLine();
decimal nota = decimal.Parse(auxNota);

if (nota is < 0m or > 10m)
{
    Console.Write("Nota Inválida!");
    return;
}

string status = nota switch
{
    >= 9m and <= 10m => "Excelente.",
    >= 7m and <= 8.9m => "Bom.",
    >= 5m and <= 6.9m => "Recuperação.",
    >= 0m and <= 4.9m => "Reprovado.",
    _ => "Erro."
};

Console.Write($"\nNota: {nota:F2} \nStatus: {status}");