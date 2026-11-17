string[] cidade = new string[15];
for (int i = 0; i < 15; i++)
{
    Console.WriteLine("Digite o nome da posição " + i + "°: ");
    cidade[i] = Console.ReadLine();

    Console.WriteLine("O nome da cidade da posição " + i + "° é: " + cidade[i]);
}