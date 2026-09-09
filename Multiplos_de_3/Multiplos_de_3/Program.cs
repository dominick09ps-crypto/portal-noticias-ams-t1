int resto, quant = 0, cont = 1;
while (cont <= 20)
{
    resto = cont % 3;

    if (resto == 0)
    {    
        Console.WriteLine("O número é multiplo de 3: " + cont);
        quant++;
    }
    else
    {
        Console.WriteLine("O número não é multiplo de 3: " + cont);
    }
    cont++;
}
Console.WriteLine("A quantidade de multiplos de 3: " + quant);