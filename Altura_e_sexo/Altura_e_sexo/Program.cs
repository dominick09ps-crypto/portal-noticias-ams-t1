double altura, quant = 0;
string sexo;
for (int i = 1; i <= 4; i++)
{
    Console.WriteLine("Digite o sexo da pessoa: ");
    sexo = Console.ReadLine();
    Console.WriteLine("Digite a altura da pessoa: ");
    altura = double.Parse(Console.ReadLine());

    if(sexo == "Masculino" ||  sexo == "masculino")
    {
        quant++;
        Console.WriteLine("A pessoa é homem, e são: " + quant); 
    }
    else if(sexo == "Feminino" || sexo == "feminino")
    {
        Console.WriteLine("A pessoa é mulher, cujo a altura mede: " + altura);
    }
}