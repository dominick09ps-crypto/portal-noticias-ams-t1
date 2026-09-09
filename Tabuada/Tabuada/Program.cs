int n, tabuada, cont = 1;
Console.WriteLine("Digite um número: ");
n = int.Parse(Console.ReadLine());
while (cont <= 30)
{
    tabuada = cont * n;
    Console.WriteLine("A tabuada é: " + tabuada);
    cont++;
}