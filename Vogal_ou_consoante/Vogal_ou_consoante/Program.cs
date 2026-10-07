string letra;
for (int i = 1; i <= 25; i++)
{ 
Console.WriteLine("Digite uma letra: ");
letra = Console.ReadLine();

    switch (letra)
    {
        case "A":
        case "a":
            Console.WriteLine("É uma vogal");
            break;

        case "E":
        case "e":
            Console.WriteLine("É uma vogal");
            break;

        case "I":
        case "i":
            Console.WriteLine("É uma vogal");
            break;

        case "O":
        case "o":
            Console.WriteLine("É uma vogal");
            break;

        case "U":
        case "u":
            Console.WriteLine("É uma vogal");
            break;

        default:
            Console.WriteLine("É uma consoante");
            break;
    }
}