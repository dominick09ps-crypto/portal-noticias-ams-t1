int quantp = 0, quantn = 0, num;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    if(num > 0)
    {
        Console.WriteLine("Números positivos");
        quantp++;
    }
    else if(num < 0)
    {
        Console.WriteLine("Números negativos");
        quantn++;
    }
}
Console.WriteLine("A quantidade de positivos: " + quantp);
Console.WriteLine("A quantidade de negativos: " + quantn);