string[] nome = new string[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o nome na posição " + i + "° do vetor: ");
    nome[i] = Console.ReadLine();
}

int[] idade = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite a idade na posição " + i + "° do vetor: ");
    idade[i] = int.Parse(Console.ReadLine());

    if (idade[i] > 30)
    {
        Console.WriteLine(nome[i] + " da posição " + i + "°, tem mais de 30 anos");
    }
    else
    {
        Console.WriteLine(nome[i] + " da posição " + i + "°, tem menos de 30 anos");
    }
}