int resto, cont = 1;
while(cont <= 800)
{
    resto = cont % 2;
    if(resto == 0)
    {
        Console.WriteLine("Os números pares são: " + cont);
    }  
    cont++;
}