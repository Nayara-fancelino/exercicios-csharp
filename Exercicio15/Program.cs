double[] notas = new double[8];
double soma = 0;

for (int i = 0; i < 8; i++)
{
    Console.Write($"Digite a {i + 1}ª nota: ");
    notas[i] = double.Parse(Console.ReadLine());

    soma = soma + notas[i];
}

double media = soma / 8;

Console.WriteLine($"Média das notas: {media:F2}");
