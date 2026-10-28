int num, tres, quatro, cinco, quant = 0, quanti = 0, quantidade = 0;
for (int i = 1; i <= 20; i++)
{
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    tres = num % 3;
    quatro = num % 4;
    cinco = num % 5;

    if (tres == 0)
    {
        quant++;
        Console.WriteLine("É multiplo de 3: " + num);
    }

    else if(quatro == 0)
    {
        quanti++;
        Console.WriteLine("É multiplo de 4: " + num);
    }

    else if(cinco == 0)
    {
        quantidade++;
        Console.WriteLine("É multiplo de 5: " + num);
    }
}
Console.WriteLine("A quantidade dos múltiplos de 3: " + quant);
Console.WriteLine("A quantidade dos múltiplos de 4: " + quanti);
Console.WriteLine("A quantidade dos múltiplos de 5: " + quantidade);