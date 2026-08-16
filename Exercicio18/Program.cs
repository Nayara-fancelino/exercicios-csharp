Random random = new Random();
int numeroSorteado = random.Next(1, 101);

int tentativa = 0;

while (tentativa != numeroSorteado)
{
    Console.Write("Digite um número entre 1 e 100: ");
    tentativa = int.Parse(Console.ReadLine());

    if (tentativa < numeroSorteado)
    {
        Console.WriteLine("O número sorteado é maior.");
    }
    else if (tentativa > numeroSorteado)
    {
        Console.WriteLine("O número sorteado é menor.");
    }
}

Console.WriteLine("Parabéns! Você acertou o número.");
