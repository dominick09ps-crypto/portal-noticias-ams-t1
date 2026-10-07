string[] elemento = new string[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite o elemento na posição " + i + "° do vetor: ");
    elemento[i] = Console.ReadLine();
}

string[] sigla = new string[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite a sigla na posição " + i + "° do vetor: ");
    sigla[i] = Console.ReadLine();
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("A sigla do " + elemento[i] + " do vetor é: " + sigla[i]);
}