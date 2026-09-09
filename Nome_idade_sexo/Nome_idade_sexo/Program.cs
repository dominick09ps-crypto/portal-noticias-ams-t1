string nome, sexo;
int idade;
for (int i = 1; i <= 3; i++)
{
    Console.WriteLine("Digite o nome da pessoa: ");
    nome = Console.ReadLine();
    Console.WriteLine("Digite o sexo da pessoa: ");
    sexo = Console.ReadLine();
    Console.WriteLine("Digite a idade da pessoa: ");
    idade = int.Parse(Console.ReadLine());

    if((idade > 21) && (sexo == "Masculino"))
    {
        Console.WriteLine("A pessoa é um homem maior que 21: " + nome);
    }
    else if ((idade < 21) && (sexo == "Masculino"))
    {
        Console.WriteLine("A pessoa é um homem menor que 21: " + nome);
    }
    else if ((idade > 21) && (sexo == "Feminino"))
    {
        Console.WriteLine("A pessoa é uma mulher maior que 21: " + nome);
    }
    else if ((idade < 21) && (sexo == "Feminino"))
    {
        Console.WriteLine("A pessoa é uma mulher menor que 21: " + nome);
    }
}