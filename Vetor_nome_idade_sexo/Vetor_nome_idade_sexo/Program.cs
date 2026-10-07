string[] nome = new string[4];
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Digite o nome na posição " + i + "° do vetor: ");
    nome[i] = Console.ReadLine();
}

int[] idade = new int[4];
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Digite a idade na posição " + i + "° do vetor: ");
    idade[i] = int.Parse(Console.ReadLine());
}

string[] sexo = new string[4];
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Digite o sexo na posição " + i + "° do vetor: ");
    sexo[i] = Console.ReadLine();
}

for (int i = 0;i < 4;i++)
{
    Console.WriteLine("O nome na posição " + i + "° do vetor é: " + nome[i]);
    Console.WriteLine("A idade na posição " + i + "° do vetor é: " + idade[i]);
    Console.WriteLine("O sexo na posição " + i + "° do vetor é: " + sexo[i]);
}