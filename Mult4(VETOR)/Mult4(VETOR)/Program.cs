int[] num = new int[10];
int resto;
for (int i = 0; i < 10; i++)
{
    resto = i % 4;

    if (resto == 0 && i != 0)
    {
        Console.WriteLine("O número da posição " + i + " é múltiplos de 4");
    }
}