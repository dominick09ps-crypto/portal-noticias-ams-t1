int num, cont = 1;
while (cont <= 22)
{
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    if (num < 0)
    {
        Console.WriteLine("O número é menor que 0");
    }
    if (num == 0)
    {
        Console.WriteLine("O número é igual a 0");
    }
    if (num > 0)
    {
        Console.WriteLine("O número é maior que 0");
    }
    cont++;
}