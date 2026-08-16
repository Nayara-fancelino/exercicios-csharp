Console.Write("Digite a base do retângulo: ");
double baseRetangulo = double.Parse(Console.ReadLine());

Console.Write("Digite a altura do retângulo: ");
double altura = double.Parse(Console.ReadLine());

double area = baseRetangulo * altura;
double perimetro = 2 * (baseRetangulo + altura);

Console.WriteLine($"Área: {area}");
Console.WriteLine($"Perímetro: {perimetro}");