string[] cantor = new string[12];
for (int i = 0; i < 12; i++)
{
    Console.WriteLine("Digite o nome da posição " + i + "°: ");
    cantor[i] = Console.ReadLine();

    Console.WriteLine("O nome do(A) cantor(A) da posição " + i + "° é: " + cantor[i]);
}