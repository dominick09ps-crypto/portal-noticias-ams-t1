double[] produto = new double[15];
double soma = 0;
for (int i = 0; i < 15; i++)
{
    Console.WriteLine("Digite o preço do produto na posição " + i + "º: ");
    produto[i] = int.Parse(Console.ReadLine());
    soma = soma + produto[i];

    Console.WriteLine("O preço do produto " + i + "° é: " + produto[i]);
}
Console.WriteLine("A soma de todos os produtos é: " + soma);