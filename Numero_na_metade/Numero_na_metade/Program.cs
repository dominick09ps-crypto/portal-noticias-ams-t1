int num;
double metade;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    metade = num / 2;
    Console.WriteLine("A metade é :" + metade);
}