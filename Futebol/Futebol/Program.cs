string[] nome = new string[7];
for (int i = 0; i < 7; i++)
{
    Console.WriteLine("Digite o nome na posição " + i + "° do vetor: ");
    nome[i] = Console.ReadLine();

    Console.WriteLine("O nome na posição " + i + "° do vetor é: " + nome[i]);
}