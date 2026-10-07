string[] cor = new string[15];
for (int i = 0; i < 15; i++)
{
    Console.WriteLine("Digite nome da cor da posição " + i + "° do vetor: ");
    cor[i] = Console.ReadLine();
}
for (int i = 0; i < 15; i++)
{
    Console.WriteLine("O nome da cor na posição " + i + "° no vetor é: " + cor[i]);
}