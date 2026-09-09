int idade;
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Digite a idade: ");
    idade = int.Parse(Console.ReadLine());

    if (idade >= 18)
    {
        Console.WriteLine("A pessoa é maior de idade");
    }
    else
    {
        Console.WriteLine("A pessoa é menor de idade");
    }
}