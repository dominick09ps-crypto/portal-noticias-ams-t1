int impar, cont = 500;
while (cont >= 1)
{
    impar = cont % 2;

    if (impar != 0)
    {
        Console.WriteLine("Os números ímpares são: " + cont);
    }
    cont--;
}