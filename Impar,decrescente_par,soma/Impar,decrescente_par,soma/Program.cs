int soma, resto = 0, cont = 800;
while (cont >= 1)
{
    resto = cont % 2;

    if(resto == 0)
    {
        soma = cont + cont;
        Console.WriteLine("Os números pares são: " + cont + ", e a soma é: " + soma);
        cont--;
    }
    else if(resto != 0)
    {
        Console.WriteLine("Os números ímpares são: " + cont);
        cont--;
    }
}