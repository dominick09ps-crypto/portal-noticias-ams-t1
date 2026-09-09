int mult, cont = 100;
while (cont <= 500)
{
    mult = cont % 3;

    if (mult == 0)
    {
        Console.WriteLine("Os multiplos de 3 são: " + cont);
    }
    cont++;
}