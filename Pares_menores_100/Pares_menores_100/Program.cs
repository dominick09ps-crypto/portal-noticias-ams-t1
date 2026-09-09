double resto, cont = 100;
while (cont >= 1)
{
    resto = cont % 2;

    if(resto == 0)
    {
        Console.WriteLine("Os pares menores que 100 são: " + cont);
    }
    cont--;
}