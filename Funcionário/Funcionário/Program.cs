string[] nome = new string[6];
for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Digite o nome na posição " + i + "° do vetor: ");
    nome[i] = Console.ReadLine();
}

string[] cargo = new string[6];
for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Digite o cargo na posição " + i + "° do vetor: ");
    cargo[i] = Console.ReadLine();
}

int[] idade = new int[6];
for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Digite a idade na posição " + i + "° do vetor: ");
    idade[i] = int.Parse(Console.ReadLine());
}

for (int i = 0;i < 6; i++)
{
    Console.WriteLine("O nome na poisição " + i + "° do vetor é: " + nome[i]);
    Console.WriteLine("O cargo na poisição " + i + "° do vetor é: " + cargo[i]);
    Console.WriteLine("A idade na poisição " + i + "° do vetor é: " + idade[i]);
}