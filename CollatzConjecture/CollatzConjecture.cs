// Carlos Gabriel Leite Carretts //
Console.Write("Digite o valor inicial de x: ");
int x = int.Parse(Console.ReadLine());
int y = 0;
while (y != 1)
{
    y = (x % 2 == 0) ? (x / 2) : (3 * x + 1);

    if (y != 1)
    {
        Console.Write($"{y} -> ");
    }
    else
    {
        Console.Write($"{y}\n");
    }
    x = y;
}