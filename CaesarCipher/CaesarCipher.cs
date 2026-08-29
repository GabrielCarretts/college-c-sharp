// Carlos Gabriel Leite Carretts //
Console.Write("Digite o texto plano: ");
string textoPlano = Console.ReadLine();
int passo = 4;
string textoCifrado = cifra(textoPlano, passo);
string textoDecifrado = decifra(textoCifrado, passo);
Console.WriteLine($"Texto original: {textoPlano}");
Console.WriteLine($"Texo cifrado: {textoCifrado}");
Console.WriteLine($"Texto plano: {textoDecifrado}");
static string cifra(string textoPlano, int passo)
{
    string textoCifrado = "";
    foreach (char caractere in textoPlano)
    {
        char passado = (char)(caractere + passo);
        textoCifrado += passado;
    }
    return textoCifrado;
}
static string decifra(string textoCifrado, int passo)
{
    string textoDecifrado = "";
    foreach (char caractere in textoCifrado)
    {
        char passado = (char)(caractere - passo);
        textoDecifrado += passado;
    }
    return textoDecifrado;
}