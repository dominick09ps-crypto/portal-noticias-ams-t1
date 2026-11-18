int[] num = new int[20];
int resto;
for (int i = 0; i < 20; i++)
{
    Console.WriteLine("Digite um número na posição " + i + "°: ");
    num[i] = int.Parse(Console.ReadLine());
    resto = num[i] % 5;

    if (resto == 0)
    {
        Console.WriteLine("O número da posição " + i + "° é multiplo de 5");
    }
    else
    {
        Console.WriteLine("O número da posição " + i + "° não é multiplo de 5");
    }
}