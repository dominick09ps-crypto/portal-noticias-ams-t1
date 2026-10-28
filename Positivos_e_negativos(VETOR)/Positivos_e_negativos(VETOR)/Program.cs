int[] num = new int[10];
int positivo = 0, negativo = 0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite um número da posição " + i);
    num[i] = int.Parse(Console.ReadLine());

    if(num[i] > 0)
    {
        positivo++;
        Console.WriteLine("O número da posição " + i + " é positivo");
    }
    else if (num[i] == 0)
    {
        Console.WriteLine("O número da posição " + i + " é igual a 0");
    }
    else
    {
        negativo++;
        Console.WriteLine("O número da posição " + i + " é negativo");
    }    
}
Console.WriteLine("A quantidade de números positivos é " + positivo);
Console.WriteLine("A quantidade de números negativos é " + negativo);