int par, cont = 1;
while (cont <= 700)
{
    par = cont % 2;
    if (par != 0)
    {
        Console.WriteLine(cont + "é um número ímpar");
    }
    cont++;
}