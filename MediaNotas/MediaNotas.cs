public class MediaNotas
{
    decimal[] notas;
    public decimal SomarNotas()
    {
        decimal soma = default;
        foreach (decimal nota in notas)
        {
            soma += nota;
        }
        return soma;
    }
    public decimal CalcularMedia(decimal soma)
    {
        decimal mediaNotas = soma / notas.Length;
        return mediaNotas;
    }

    public void DefinirNotas(decimal[] notasRecebidas)
    {
        notas = notasRecebidas;
    }
}