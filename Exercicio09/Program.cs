int soma = 0;

for (int numero = 2; numero <= 100; numero += 2)
{
    soma = soma + numero;
}

Console.WriteLine($"A soma dos números pares entre 1 e 100 é: {soma}");
