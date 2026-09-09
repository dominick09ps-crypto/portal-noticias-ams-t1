int par, cont = 1;
while (cont <= 500)
{
    par = cont % 2;

    if (par == 0)
    { 
    Console.WriteLine("Os números pares até 500 são: " + cont);
    }
    cont++;
}