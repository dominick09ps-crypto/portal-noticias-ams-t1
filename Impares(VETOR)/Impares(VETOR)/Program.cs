int[] num = new int[10];
int resto, quantidade = 0;
for (int i = 0; i < 10; i++)
{
    resto = i % 2;
    if (resto != 0)
    {
        Console.WriteLine("O número da posição " + i + " é ímpar");
    }
    else
    {
        quantidade++;
    }
}

Console.WriteLine("A quantidade de números pares é:" + quantidade);