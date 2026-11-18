int[] num = new int[5];
double media = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o número da posição " + i + "°: ");
    num[i] = int.Parse(Console.ReadLine());
    media = (num[0] + num[1] + num[2] + num[3] + num[4]) / 5;
}
Console.WriteLine("A média é: " + media);