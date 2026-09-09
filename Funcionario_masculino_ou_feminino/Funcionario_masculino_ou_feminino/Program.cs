int cont = 1;
string sexo, nome;
while (cont <= 15)
{
    Console.WriteLine("Digite o nome do funcionário(A): ");
    nome = Console.ReadLine();
    Console.WriteLine("Digite o sexo do funcionário: ");
    sexo = Console.ReadLine();

    if (sexo == "Masculino" ||  sexo == "masculino")
    {
        Console.WriteLine("O funcionário: " + nome + ", do sexo: " + sexo + ", precisa fazer o exame");
    }
    else if (sexo == "Feminino" || sexo == "feminino")
    {
        Console.WriteLine("A funcionária: " + nome + ", do sexo: " + sexo + ", não precisa fazer o exame");
    }
    else
    {
        Console.WriteLine("O usuário digitou errado");
    }
    cont++;
}