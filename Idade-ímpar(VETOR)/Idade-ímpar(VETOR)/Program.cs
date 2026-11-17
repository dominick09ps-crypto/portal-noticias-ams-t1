int[] idade = new int[14];
int resto;
for (int i = 0; i < 14; i++)
{
    Console.WriteLine("Digite a idade da posição " + i + "°: ");
    idade[i] = int.Parse(Console.ReadLine());
    resto = idade[i] % 2;

    if (resto != 0)
    {
        Console.WriteLine("A idade da posição " + i + "° é ímpar, " + idade[i]);
    }
}