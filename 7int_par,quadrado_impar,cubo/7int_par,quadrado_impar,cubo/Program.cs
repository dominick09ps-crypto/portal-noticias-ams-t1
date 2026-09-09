int par, impar, quadrado, cubo, cont = 1;
while (cont <= 7)
{
    par = cont % 2;

    if (par == 0)
    {
        quadrado = cont * cont;
        Console.WriteLine("O quadrado dos números pares são: " + quadrado);
    }
    else if (par != 0)
    {
        cubo = cont * cont * cont;
        Console.WriteLine("O cubo dos números impares são: " + cubo);
    }
    cont++;
}