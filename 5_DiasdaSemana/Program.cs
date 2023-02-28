void PrintarDiasDaSemana()
{
    Console.WriteLine("Insira um número: ");
    string input = Console.ReadLine();

    switch(input)
    {
        case "1":
            Console.WriteLine("1 - Domingo");
            break;

        case "2":
            Console.WriteLine("2 - Segunda-Feira");
            break;

        case "3":
            Console.WriteLine("3 - Terça-Feira");
            break;

        case "4":
            Console.WriteLine("4 - Quarta-Feira");
            break;

        case "5":
            Console.WriteLine("5 - Quinta-Feira");
            break;

        case "6":
            Console.WriteLine("6 - Sexta-Feira");
            break;

        case "7":
            Console.WriteLine("7 - Sábado");
            break;

        default:
            Console.WriteLine("Número Inválido");
            break;
    }
}

PrintarDiasDaSemana();