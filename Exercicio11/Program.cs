int soma = 0;

while (true)
{
    Console.Write("Digite um número (0 para encerrar): ");
    int numero = int.Parse(Console.ReadLine());

    if (numero == 0)
    {
        break;
    }

    soma = soma + numero;
}

Console.WriteLine($"A soma dos valores digitados é: {soma}");
