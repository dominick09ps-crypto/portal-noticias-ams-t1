string[] nome = new string[5];
int[] idade = new int[5];
double[] peso = new double[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o nome na posição " + i + "°: ");
    nome[i] = Console.ReadLine();
    Console.WriteLine("Digite a idade na posição " + i + "°: ");
    idade[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o peso na posição " + i + "°: ");
    peso[i] = double.Parse(Console.ReadLine());

    Console.WriteLine(nome[i] + " da posição " + i + "°, tem " + idade[i] + " anos, e seu peso é " + peso[i] + " kg");
}