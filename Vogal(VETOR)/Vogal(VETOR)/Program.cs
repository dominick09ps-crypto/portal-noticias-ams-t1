string[] vogal = new string[26];
for (int i = 0; i < 26; i++)
{
    Console.WriteLine("Digite a letra da posição " + i + "°");
    vogal[i] = Console.ReadLine();

    if (vogal[i] == "A" || vogal[i] == "a")
    {
        Console.WriteLine(vogal[i] + " é uma vogal");
    }
    else if (vogal[i] == "E" || vogal[i] == "e")
    {
        Console.WriteLine(vogal[i] + " é uma vogal");
    }
    else if (vogal[i] == "I" || vogal[i] == "i")
    {
        Console.WriteLine(vogal[i] + " é uma vogal");
    }
    else if (vogal[i] == "O" || vogal[i] == "o")
    {
        Console.WriteLine(vogal[i] + " é uma vogal");
    }
    else if (vogal[i] == "U" || vogal[i] == "u")
    {
        Console.WriteLine(vogal[i] + " é uma vogal");
    }
    else
    {
        Console.WriteLine(vogal[i] + " não é uma vogal");
    }
}