string[] nome = new string[11];
for (int i = 0; i < 11; i++)
{
    Console.WriteLine("Digite o nome do jogador da posição " + i + "°");
    nome[i] = Console.ReadLine();
}
for (int i = 0; i < 11; i++)
{
    Console.WriteLine("O nome do jogador na posição " + i + "° é: " + nome[i]);
}