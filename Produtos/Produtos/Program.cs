string[] nome = new string[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o nome na posição " + i + "° do vetor: ");
    nome[i] = Console.ReadLine();
}

double[] preco = new double[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o preço na posição " + i + "° do vetor: ");
    preco[i] = double.Parse(Console.ReadLine());
}

for (int i = 0;i < 5; i++)
{
    Console.WriteLine("O preço do(A) " + nome[i] + " é " + preco[i]);
}