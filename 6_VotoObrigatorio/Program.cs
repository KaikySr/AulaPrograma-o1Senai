void Voto()
{
    Console.WriteLine("Insira sua idade: ");
    string input = Console.ReadLine();

    if (int.Parse(input) < 16)
        Console.WriteLine("Você não pode votar.");

    else if (int.Parse(input) >= 16 && int.Parse(input) < 18 || int.Parse(input) >= 70)
        Console.WriteLine("Seu voto é facultativo");

    else
        Console.WriteLine("Seu voto é obrigatorio");
}

Voto();