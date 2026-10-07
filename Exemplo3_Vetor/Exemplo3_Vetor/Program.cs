// Para criar vetor string
string[] nome = new string[5];
// Criar vetor int
int[] idade = new int[5];

// Para armazenar os valores no vetor
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o nome da posição " + i + "° do vetor");
    nome[i] = Console.ReadLine();
    Console.WriteLine("Digite a idade da posição: ");
    idade[i] = int.Parse(Console.ReadLine());
}

// Para mostrar os valores do vetor
for (int i = 0;i < 5;i++)
{
    Console.WriteLine("O nome armazenado na posição " + i + "° do vetor é = " + nome[i]);
    Console.WriteLine("A idade armazenada na posição " + i + "° do vetor é = " + idade[i]);
}