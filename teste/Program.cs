void CalcularHoras()
{
    Console.WriteLine("Insira o valor da hora trabalhada: ");
    string inputValor = Console.ReadLine();

    Console.WriteLine("Insira as horas trabalhadas: ");
    string inputHoras = Console.ReadLine();

    if(double.Parse(inputHoras) > 220)
    {
        Console.WriteLine("Você está trabalhando mais do que é permitido.");
    }
    else 
    { 
        double salarioMensal = double.Parse(inputHoras) * double.Parse(inputValor);

        Console.WriteLine("Seu salário mensal é de R$" + salarioMensal);
    }
}

CalcularHoras();