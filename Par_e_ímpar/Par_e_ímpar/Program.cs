int par, quant = 0, quantidade = 0;
for (int i = 1; i <= 24; i++)
{
    par = i % 2;
    if (par == 0)
    {
        Console.WriteLine(i + " é par");
        quant++;
    }
    else if (par != 0)
    {
        Console.WriteLine(i + " é ímpar");
        quantidade++;
    }
}
Console.WriteLine("A quantidade de números pares é:" + quant);
Console.WriteLine("A quantidade de números ímpares é:" + quantidade);