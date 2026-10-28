int n, tabuada, cont = 1;
Console.WriteLine("Digite um número: ");
n = int.Parse(Console.ReadLine());
while (cont <= 10)
{
    tabuada = cont * n;
    Console.WriteLine(cont + " -> " + tabuada);
    cont++;
}