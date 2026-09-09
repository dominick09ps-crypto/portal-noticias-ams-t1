string nome;
double a, b, media;
int cont = 1;
while (cont <= 5)
{
    Console.WriteLine("Digite o nome do aluno: ");
    nome = Console.ReadLine();
    Console.WriteLine("Digite a primeira nota do aluno: ");
    a = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a segunda nota do aluno: ");
    b = double.Parse(Console.ReadLine());
    media = (a + b) / 2;

    Console.WriteLine("O nome do aluno é: " + nome + ", e sua media de nota é: " + media);
    cont++;
}