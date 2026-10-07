int[] vetor = new int[10];
double par;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite um número dentro da posição " + i + "° do vetor");
    vetor[i] = int.Parse(Console.ReadLine());
    par = vetor[i] % 2;
    if (par == 0)
    {
        Console.WriteLine(vetor[i] + " é par");
    }
    else
    {
        Console.WriteLine(vetor[i] + " é impar");
    }
}