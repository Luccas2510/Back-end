using System.Globalization;

try
{
    Console.Write("Digite um número: ");
double num1;
    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out num1))
    {
        Console.WriteLine("Erro: digite um número válido.");
        Console.Write("Digite o primeiro número");
    }

    Console.Write("\nDigite outro número: ");
double num2;
    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out num2))
    {
        Console.WriteLine("Erro: digite um número válido.");
        Console.Write("Digite o segundo");
    }

    double resultado = num1 + num2;
Console.WriteLine($"O resultado da soma é: {resultado}");
}catch(FormatException)
{
    Console.WriteLine("Erro: por favor, digite números válidos");
} 

Console.ReadKey();