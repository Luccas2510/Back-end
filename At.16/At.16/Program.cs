
Console.Write("Digite um número ineiro: ");

if (int.TryParse(Console.ReadLine(), out int num) && num >= 0)
{
    long fatorial = 1;


    for (int i = 1; i <= num; i++)
    {
        fatorial *= i;
    }


    Console.WriteLine($"O fatorial de {num} é  = {fatorial}");
}
else
{
    Console.WriteLine("insira um número inteiro positivo.");
}

Console.WriteLine("Digite qualquer tecla para encerrar!");
Console.ReadKey();