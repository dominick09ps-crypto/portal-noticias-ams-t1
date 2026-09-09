int num, soma = 0;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    soma = num + soma;
    Console.WriteLine("A soma é: " + soma);
}