string senhaCorreta = "1234";

Console.Write("Digite o usuário: ");
string usuario = Console.ReadLine();

Console.Write("Digite a senha: ");
string senha = Console.ReadLine();

while (senha != senhaCorreta)
{
    Console.Write("Senha incorreta. Digite novamente: ");
    senha = Console.ReadLine();
}

Console.WriteLine($"Login realizado com sucesso. Bem-vindo, {usuario}!");
