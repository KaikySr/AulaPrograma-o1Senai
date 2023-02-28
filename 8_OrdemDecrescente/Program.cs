void Decrescente()
{
    Console.WriteLine("Insira o primeiro valor: ");
    string valor1 = Console.ReadLine();

    Console.WriteLine("Insira o segundo valor: ");
    string valor2 = Console.ReadLine();

    Console.WriteLine("Insira o terceiro valor: ");
    string valor3 = Console.ReadLine();

    int[] numeros = { int.Parse(valor1), int.Parse(valor2), int.Parse(valor3) };

    numeros = numeros.OrderByDescending(e => e).ToArray();

   foreach(int numero in numeros)
   {
        Console.WriteLine(numero);
   }
}

Decrescente();
   