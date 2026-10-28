string[] nome = new string[8];
int[] idade = new int[8];
string[] curso = new string[8];
for (int i = 0; i < 8; i++)
{
    Console.WriteLine("Digite o nome do aluno da posição " + i);
    nome[i] = Console.ReadLine();
    Console.WriteLine("Digite a idade do aluno da posição " + i);
    idade[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o curso do aluno da posição " + i);
    curso[i] = Console.ReadLine();

    Console.WriteLine("O aluno(A) " + nome[i] + " da posição " + i + " tem " + idade[i] + " anos, e está no curso " + curso[i]);
}