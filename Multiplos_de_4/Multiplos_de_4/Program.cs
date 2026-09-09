int resto, quant = 0, cont = 1;
while (cont <= 750)
{
    resto = cont % 4;

    if (resto == 0)
    { 
        Console.WriteLine("O número é multiplo de 4: " + cont);
        quant++;
    }
    else
    {
        Console.WriteLine("O número não é multiplo de 4: " + cont);;
    }
    cont++;
}
Console.WriteLine("A quantidade de multiplos de 4: " + quant);