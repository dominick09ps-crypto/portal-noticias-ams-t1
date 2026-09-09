int num, resto, quant = 0;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    resto = i % 4;

    if(resto == 0)
    {
        quant++;
        Console.WriteLine("É multiplo de 4: " + num);
    }
    else
    {
        quant++;
        Console.WriteLine("Não é múltiplo de 4: " + num);
    }
}