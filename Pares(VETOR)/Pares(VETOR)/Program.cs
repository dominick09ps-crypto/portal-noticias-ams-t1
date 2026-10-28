int[] num = new int[25];
int resto, par = 0, impar = 0;
for (int i = 0; i < 25; i++)
{
    resto = i % 2;

    if (resto == 0)
    {
        par++;
        Console.WriteLine("O número da posição " + i + " é par");
    }
    else
    {
        impar++;
        Console.WriteLine("O número da posição " + i + " é impar");
    }
}
Console.WriteLine("A quantidade de números pares é " + par);
Console.WriteLine("A quantidade de números impares é " + impar);