Console.Write("Digite o valor em reais: R$ ");
double valorReais = double.Parse(Console.ReadLine());

Console.Write("Digite a cotação atual do dólar: R$ ");
double cotacaoDolar = double.Parse(Console.ReadLine());

double valorDolares = valorReais / cotacaoDolar;

Console.WriteLine($"Valor em dólares: US$ {valorDolares:F2}");
