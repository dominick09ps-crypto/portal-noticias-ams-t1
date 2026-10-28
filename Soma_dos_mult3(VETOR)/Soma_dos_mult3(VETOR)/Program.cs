int[] num = new int[10];
int soma = 0, resto;
for (int i = 0; i < 10; i++)
{
    resto = i % 3;
    if (resto == 0 && i != 0)
    {
        soma = soma + i;
        Console.WriteLine("O número da posição " + i + " é múltiplo de 3, e sua soma é " + soma);
    }
}