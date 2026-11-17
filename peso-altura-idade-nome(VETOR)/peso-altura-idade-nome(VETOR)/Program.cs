double[] peso = new double[6];
double[] altura = new double[6];
int[] idade = new int[6];
string[] nome = new string[6];
for  (int i = 0; i < 6; i++)
{
    Console.WriteLine("Digite o peso da posição " + i + "°");
    peso[i] = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a altura da posição " + i + "°");
    altura[i] = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a idade da posição " + i + "°");
    idade[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o nome da posição " + i + "°");
    nome[i] = Console.ReadLine();

    if (idade[i] > 20)
    {
        Console.WriteLine("O(A) " + nome[i] + " da posição " + i + "° tem " + peso[i] + "kg, e tem " + idade[i] + " anos, é mais de 20");
    }
    else
    {
        Console.WriteLine("O(A) " + nome[i] + " da posição " + i + "° tem " + idade[i] + " anos, é menos de 20");
    }
}