string[] veterinario = new string[10];
string[] animal = new string[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite o nome do veterinário na posição " + i + "°: ");
    veterinario[i] = Console.ReadLine();
    Console.WriteLine("Digite o nome do animal na posição " + i + "°: ");
    animal[i] = Console.ReadLine();

    Console.WriteLine("O(A) " + veterinario[i] + " da posição " + i + "° está cuidando de um " + animal[i]);
}