int anoatual, anonasc, idade, cont = 1;
while (cont <= 5)
{
    Console.WriteLine("Digite o ano atual: ");
    anoatual = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o ano de nascimento: ");
    anonasc = int.Parse(Console.ReadLine());
    idade = anoatual - anonasc;

    Console.WriteLine("A idade da pessoa é: " + idade);
    cont++;
}