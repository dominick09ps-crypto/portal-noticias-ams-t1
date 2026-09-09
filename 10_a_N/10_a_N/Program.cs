double n = 0, divisao, cont = 10;
    Console.WriteLine("Digite um número maior que 10: ");
    n = double.Parse(Console.ReadLine());
    
while (cont <= n)
{
    divisao = cont / 3;
    Console.WriteLine("A divisão por 3 é: " + divisao);
    cont++;
}