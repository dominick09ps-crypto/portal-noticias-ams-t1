int cont = 1, nascimento, atual, idade;
string nome;
while (cont <= 4)
{
    Console.WriteLine("Digite o nome da pessoa: ");
    nome = Console.ReadLine();
    Console.WriteLine("Digite o ano atual: ");
    atual  = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o ano de nascimento: ");
    nascimento  = int.Parse(Console.ReadLine());
    idade = atual - nascimento;

    Console.WriteLine("O nome da pessoa é: " + nome + ",e a idade da pessoa é: " + idade);
    cont++;
}