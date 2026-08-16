int[] numeros = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

int maior = numeros[0];
int posicaoMaior = 0;

for (int i = 1; i < 10; i++)
{
    if (numeros[i] > maior)
    {
        maior = numeros[i];
        posicaoMaior = i;
    }
}

Console.WriteLine($"Maior valor: {maior}");
Console.WriteLine($"Posição: {posicaoMaior + 1}");
