string[] sexo = new string[5];
double[] altura = new double[5];
int quantidade = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o sexo da pessoa da posição " + i);
    sexo[i] = Console.ReadLine();
    Console.WriteLine("Digite a altura da pessoa da posição " + i);
    altura[i] = double.Parse(Console.ReadLine());

    if (sexo[i] == "Masculino" || sexo[i] == "masculino")
    {
        quantidade++;
        Console.WriteLine("A pessoa da posição " + i + " é do sexo masculino");
    }
    else if (sexo[i] == "Feminino" || sexo[i] == "feminino")
    {
        Console.WriteLine("A pessoa da posição " + i + " é do sexo feminino, e a sua altura é " + altura[i]);
    }
}
Console.WriteLine("A quantidade de homens é " + quantidade);                                                                                                                                                     