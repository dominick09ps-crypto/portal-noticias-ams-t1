string[] esporte = new string[12];
for (int i = 0; i < 12; i++)
{
    Console.WriteLine("Digite a modalidade do esporte da posição " + i);
    esporte[i] = Console.ReadLine();

    Console.WriteLine("A modalidade da posição " + i + " é: " + esporte[i]);
}