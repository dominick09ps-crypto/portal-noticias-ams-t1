int[] num = new int[16];
int resto;
for (int i = 0; i < 16; i++)
{
    resto = i % 3;

    if (resto == 0 && i != 0)
    {
        Console.WriteLine("O número da posição " + i + " é múltiplos de 3");
    }
}