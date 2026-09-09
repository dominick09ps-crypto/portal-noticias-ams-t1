int num, resto, quant = 0;
for (int i = 1; i <= 15; i++)
{
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    resto = num % 2;

    if(resto == 0)
    {
        quant++;
        Console.WriteLine(num + "é par");
    }
    else 
    {
        quant++;
        Console.WriteLine(num + "é impar");
    }
}