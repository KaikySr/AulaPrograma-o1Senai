void energia()
{
    Console.WriteLine("Formula: Valor da Energia Gasta = Potência(kWh) * Horas * Valor do kWh");

    Console.WriteLine("Insira a Potência(em kWh): ");
    double potencia = double.Parse(Console.ReadLine());

    Console.WriteLine("Insira as Horas: ");
    double Horas = double.Parse(Console.ReadLine());

    Console.WriteLine("Insira o Valor do kWh: ");
    double ValorkWh = double.Parse(Console.ReadLine());

    double totalGasto = potencia * Horas * ValorkWh;

    Console.WriteLine("O valor total gasto é de " + totalGasto);
}

energia();