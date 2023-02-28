using System.Linq;

void MaiorNumero()
{
    Console.WriteLine("Insira somente valores acima de 0.");

    Console.WriteLine("Insira o primeiro valor: ");
    string valor1 = Console.ReadLine();

    Console.WriteLine("Insira o segundo valor: ");
    string valor2 = Console.ReadLine();

    Console.WriteLine("Insira o terceiro valor: ");
    string valor3 = Console.ReadLine();

    int[] numeros = { int.Parse(valor1), int.Parse(valor2), int.Parse(valor3) };

    int maior = -1;

    for (int i = 0; i < numeros.Length; i++)
    {
        if (numeros[i] > maior)
            maior = numeros[i];
    }

    Console.WriteLine("O maior valor é " + maior);
}

MaiorNumero();