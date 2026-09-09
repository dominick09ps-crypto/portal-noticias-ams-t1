int num, resultado;
Console.WriteLine("Digite um número: ");
num = int.Parse(Console.ReadLine());

int cont = 1;
while (cont <= num)
{
    resultado = cont * cont;
    Console.WriteLine("O resultado é: " + resultado);
    cont++;
}