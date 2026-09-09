int n, dobro, cont = 1;
Console.WriteLine("Digite um número: ");
n = int.Parse(Console.ReadLine());

while (cont <= n)
{
    dobro = cont * 2;
    Console.WriteLine("O dobro do número é: " + dobro);
    cont++;
}