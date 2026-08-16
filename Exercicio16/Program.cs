int quantidadePares = 0;

for (int i = 0; i < 20; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        quantidadePares++;
    }
}

Console.WriteLine($"Quantidade de números pares: {quantidadePares}");
