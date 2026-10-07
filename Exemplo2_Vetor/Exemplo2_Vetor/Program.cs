// Para criar vetor inteiro
int[] vetor = new int [4];

// Para armazenar os valores no vetor
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Digite o número da posição " + i + "° do vetor: ");
    vetor[i] = int.Parse(Console.ReadLine());
}
// Para mostrar os valores no vetor
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("O valor armazenado na posição " + i + "° do vetor é " + vetor[i]);
}