void ConverterFihrenheint()
{
    Console.WriteLine("Insira uma temperatura em Celsius: ");
    string input = Console.ReadLine();

    double temperatura = double.Parse(input);

    double temperaturaCelsius = ((temperatura - 32) / 9) * 5;

    Console.WriteLine(temperaturaCelsius);
}

void ConverterCelsius()
{
    Console.WriteLine("Insira uma temperatura em Fahrenheit: ");
    string input = Console.ReadLine();

    double temperatura = double.Parse(input);

    double temperaturaFahrenheit = (temperatura - 32) / 1.8;

    Console.WriteLine(temperaturaFahrenheit);
}

ConverterFihrenheint();
ConverterCelsius();