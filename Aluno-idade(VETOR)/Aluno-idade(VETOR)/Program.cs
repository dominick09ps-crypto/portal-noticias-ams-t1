int[] idade = new int[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite a idade da posição " + i + "°: ");
    idade[i] = int.Parse(Console.ReadLine());

    if (idade[i] > 14)
    {
        Console.WriteLine("A idade do aluno na posição " + i + "° é: " + idade[i] + " anos, maior que 14 anos");
    }
    else if (idade[i] == 14)
    {
        Console.WriteLine("A idade do aluno na posição " + i + "° é: " + idade[i] + " anos");
    }
    else
    {
        Console.WriteLine("A idade do aluno na posição " + i + "° é: " + idade[i] + " anos, menor que 14 anos");
    }
}