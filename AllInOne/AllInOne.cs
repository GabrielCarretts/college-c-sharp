// Carlos Gabriel Leite Carretts //
using System;
using System.Text;
internal class Program
{
    public Program()
    {
        int valor;
        do
        {
            Console.WriteLine("""
    ====> TudoJunto <====
    | 1 - Cifra de Cesar (String) |
    | 2 - Decifra de Cesar (String) |
    | 3 - Cifra de Cesar (String Builder) |
    | 4 - Decifra de Cesar (StringBuilder) |
    | 5 - Classificação Etária |
    | 6 - Sorteio |
    | 7 - Conjetura de Collatz |
    | 8 - Cálculo de Nota Fiscal |
    | 9 - Classificação de Nota |
    | 0 - Finalizar o programa |
    """);
            Console.Write("Digite o número do exercício desejado: ");
            valor = int.TryParse(Console.ReadLine(), out int auxValor) ? auxValor : -1;

            switch (valor)
            {
                case 1:
                    MenuCifraDeCesarString();
                    break;
                case 2:
                    MenuDecifraDeCesarString();
                    break;
                case 3:
                    MenuCifraDeCesarStringBuilder();
                    break;
                case 4:
                    MenuCifraDeCesarStringBuilder();
                    break;
                case 5:
                    MenuClassificacaoIdade();
                    break;
                case 6:
                    MenuSorteio();
                    break;
                case 7:
                    MenuConjeturaDeCollatz();
                    break;
                case 8:
                    MenuCalculoDeNotaFiscal();
                    break;
                case 9:
                    MenuCalculoDeNota();
                    break;
                case 0:
                    {
                        Console.WriteLine("\nEncerrando o programa...\n");
                        break;
                    }
                default:
                    Console.WriteLine("\nNúmero inválido! Digite um número válido (0-9)");
                    break;
            }
        } while (valor != 0);
    }

    // MÉTODOS DE INTERFACE //
    public void MenuCifraDeCesarString()
    {
        Console.WriteLine("\n====> Cifra de Cesar (String) <====\n");
        Console.Write("Digite o texto plano: ");
        string plano = Console.ReadLine();
        Console.Write("Diite o número do passo: ");
        byte passo = byte.TryParse(Console.ReadLine(), out byte auxPasso) ? auxPasso : default;
        Console.WriteLine("\nTexto Cifrado: " + CifraDeCesarString(plano, passo) + "\n");
    }
    public void MenuDecifraDeCesarString()
    {
        Console.WriteLine("\n====> Decifra de Cesar (String) <====\n");
        Console.Write("Digite o texto cifrado: ");
        string cifra = Console.ReadLine();
        Console.Write("Digite o número do passo: ");
        byte passo = byte.TryParse(Console.ReadLine(), out byte auxPasso) ? auxPasso : default;
        Console.WriteLine("\nTexto Decifrado: " + DecifraDeCesarString(cifra, passo) + "\n");
    }
    public void MenuCifraDeCesarStringBuilder()
    {
        Console.WriteLine("\n====> Cifra de Cesar (StringBuilder) <====\n");
        Console.Write("Digite o texto plano: ");
        string textoPlano = Console.ReadLine();
        Console.Write("Digite o número do passo: ");
        byte passo = byte.TryParse(Console.ReadLine(), out byte auxPasso) ? auxPasso : default;
        Console.WriteLine("\nTexto Cifrado: " + CifraDeCesarStringBuilder(textoPlano, passo) + "\n");
    }
    public void MenuDecifraDeCesarStringBuilder()
    {
        Console.WriteLine("\n====> Decifra de Cesar (StringBuilder) <====\n");
        Console.Write("Digite o texto cifrado: ");
        string textoCifrado = Console.ReadLine();
        Console.Write("Digite o número do passo: ");
        byte passo = byte.TryParse(Console.ReadLine(), out byte auxPasso) ? auxPasso : default;
        Console.WriteLine("\nTexto Decifrado: " + DecifraDeCesarStringBuilder(textoCifrado, passo) + "\n");
    }
    public void MenuClassificacaoIdade()
    {
        Console.WriteLine("\n====> Classificação Etária <====\n");
        Console.Write("Digite o seu nome: ");
        string nome = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome inválido!");
            return;
        }
        Console.Write("Digite a sua idade: ");
        if (!int.TryParse(Console.ReadLine(), out int idade) || idade < 0)
        {
            Console.WriteLine("Idade Inválida!");
            return;
        }
        var pessoa = (nome, idade);
        string classificacao = ClassificacaoIdade(pessoa.idade);
        Console.WriteLine($"\nNome: {pessoa.nome} \nIdade: {pessoa.idade} \nClassificação: {classificacao}\n");
    }
    public void MenuSorteio()
    {
        int valorSistema = Random.Shared.Next(0, 100);
        int valorUsuario = 0;
        Console.WriteLine("\n====> Sorteio <====\n");
        do
        {
            Console.Write("Digite um número (0 - 99, -1 para parar): ");
            valorUsuario = int.TryParse(Console.ReadLine(), out int auxValorUsuario) ? auxValorUsuario : default;
            if (valorUsuario == -1)
            {
                Console.WriteLine("\nEncerrando sorteio...\n");
                break;
            }
            string status = Sorteio(valorUsuario, valorSistema);
            string mensagem = status switch
            {
                "maior" => "Errou! Deveria ter digitado um valor maior!",
                "menor" => "Errou! Deveria ter digitado um valor menor!",
                "acerto" => "Parabéns! Você acertou o número!",
                _ => "Status desconhecido."
            };
            Console.WriteLine(mensagem);
            if (status == "acerto")
            {
                valorSistema = Random.Shared.Next(0, 100);
                Console.WriteLine("\nUm novo número foi sorteado! Tente adivinhar o próximo!\n");
            }
        }
        while (valorUsuario != -1);
    }
    public void MenuConjeturaDeCollatz()
    {
        int x = 0;
        Console.WriteLine("\n====> Conjetura de Collatz <====\n");
        Console.Write("Digite o valor de x: ");
        x = int.TryParse(Console.ReadLine(), out int auxX) ? auxX : default;
        string resultado = ConjeturaDeCollatz(x);
        Console.Write(resultado + "\n");
    }
    public void MenuCalculoDeNotaFiscal()
    {
        Console.WriteLine("\n====> Cálculo de Nota Fiscal <====\n");
        Console.Write("Digite o valor da nota fiscal: R$ ");
        decimal valorNota = Decimal.TryParse(Console.ReadLine(), out decimal auxValorNota) ? auxValorNota : default;
        var (percentual, imposto, total) = CalculoDeNotaFiscal(valorNota);
        Console.Write($"\nValor da nota fiscal: R$ {valorNota:F2} \nPercentual aplicado de imposto: {percentual * 100:F1}% \nValor do imposto: R$ {imposto:F2} \nValor total: R$ {total:F2}");
        Console.WriteLine("\n");
    }
    public void MenuCalculoDeNota()
    {
        Console.WriteLine("\n====> Classificação de Nota <====\n");
        Console.Write("Digite a nota: ");
        decimal nota = Decimal.TryParse(Console.ReadLine(), out decimal auxNota) ? auxNota : default;
        if (nota is < 0m or > 10m)
        {
            Console.Write("Nota Inválida!");
            return;
        }
        string status = CalculoDeNota(nota);
        Console.Write($"\nNota: {nota:F2} \nStatus: {status}");
        Console.WriteLine("\n");
    }

    // MÉTODOS DE LÓGICA //
    public string CifraDeCesarString(string plano, byte passo = 4)
    {
        string cifra = "";
        for (int i = 0; i < plano.Length; i++)
        {
            cifra += (char)(plano[i] + passo);
        }
        return cifra;
    }

    public string DecifraDeCesarString(string cifra, byte passo)
    {
        char[] c = cifra.ToCharArray();
        for (int i = 0; i < c.Length; i++)
        {
            c[i] = (char)(c[i] - passo);
        }
        return string.Join("", c);
    }

    public string CifraDeCesarStringBuilder(string textoPlano, byte passo = 4)
    {
        StringBuilder plano = new StringBuilder(textoPlano);
        for (int i = 0; i < textoPlano.Length; i++)
        {
            plano[i] = (char)(plano[i] + passo);
        }
        return plano.ToString();
    }

    public string DecifraDeCesarStringBuilder(string textoCifrado, byte passo)
    {
        StringBuilder cifra = new StringBuilder(textoCifrado);
        for (int i = 0; i < cifra.Length; i++)
        {
            cifra[i] = (char)(cifra[i] - passo);
        }
        return cifra.ToString();
    }

    public string ClassificacaoIdade(int idade)
    {
        string classificacao = idade switch
        {
            < 12 => "Criança.",
            <= 17 => "Adolescente.",
            <= 59 => "Adulto.",
            _ => "Idoso."
        };
        return classificacao;
    }
    public string Sorteio(int valorUsuario, int valorSistema)
    {
        return valorUsuario.CompareTo(valorSistema) switch
        {
            < 0 => "maior",
            > 0 => "menor",
            _ => "acerto"
        };
    }
    public string ConjeturaDeCollatz(int x)
    {
        int y = 0;
        StringBuilder resultadoFinal = new StringBuilder();
        while (y != 1)
        {
            y = (x % 2 == 0) ? (x / 2) : (3 * x + 1);

            if (y != 1)
            {
                resultadoFinal.Append($"{y} -> ");
            }
            else
            {
                resultadoFinal.Append($"{y}\n");
            }
            x = y;
        }
        return resultadoFinal.ToString();
    }
    public (decimal percentual, decimal imposto, decimal total) CalculoDeNotaFiscal(decimal valorNotaFiscal)
    {
        decimal percentual = valorNotaFiscal switch
        {
            <= 999.99m => 0.02m,
            <= 2999.99m => 0.025m,
            <= 6999.99m => 0.028m,
            _ => 0.03m
        };

        decimal imposto = valorNotaFiscal * percentual;
        decimal total = valorNotaFiscal + imposto;

        return (percentual, imposto, total);
    }
    public string CalculoDeNota(decimal nota)
    {
        string status = nota switch
        {
            >= 9m and <= 10m => "Excelente.",
            >= 7m and <= 8.9m => "Bom.",
            >= 5m and <= 6.9m => "Recuperação.",
            >= 0m and <= 4.9m => "Reprovado.",
            _ => "Erro."
        };
        return status;
    }
    private static void Main(string[] args)
    {
        _ = new Program();
    }
}