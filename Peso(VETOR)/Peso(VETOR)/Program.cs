string[] nome = new string[5];
double[] peso = new double[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o nome da pessoa da posição " + i);
    nome[i] = Console.ReadLine();
    Console.WriteLine("Digite o peso da pessoa da posição " + i);
    peso[i] = double.Parse(Console.ReadLine());

    if (peso[i] > 85)
    {
        Console.WriteLine("O paciente " + nome[i] + ", tem " + peso[i] + "kg, ele é tem mais de 85kg");
    }
    else
    {
        Console.WriteLine("O paciente tem menos de 85kg");
    }
}