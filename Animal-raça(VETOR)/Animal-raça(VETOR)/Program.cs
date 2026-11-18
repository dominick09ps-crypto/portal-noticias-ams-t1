string[] animal = new string[5];
string[] raca = new string[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o animal na posição " + i + "°: ");
    animal[i] = Console.ReadLine();
    Console.WriteLine("Digite a raça na posição " + i + "°: ");
    raca[i] = Console.ReadLine();

    Console.WriteLine("O animal da posição " + i + "° é um(A) " + animal[i] + ", e pertence a raça " + raca[i]);
}