int par, quant = 0, cont = 1;
while (cont <= 15)
{
    par = cont % 2;

    if (par == 0)
    {
        Console.WriteLine(cont);
        quant++;
    }
    cont++;
}
Console.WriteLine("A quantidade de número par é: " + quant);