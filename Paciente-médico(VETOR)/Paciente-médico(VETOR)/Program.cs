using System.Runtime.CompilerServices;

string[] paciente = new string[5];
string[] medico = new string[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o nome do paciente da posição " + i + "°");
    paciente[i] = Console.ReadLine();
    Console.WriteLine("Digite o nome do médico da posição " + i + "°");
    medico[i] = Console.ReadLine();

    Console.WriteLine("O nome do paciente da posição " + i + "° é: " + paciente[i]);
    Console.WriteLine("O nome do médico da posição " + i + "° é: " + medico[i]);
}