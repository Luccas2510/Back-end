int num;

Console.Write("Digite um número positivo (inteiro): ");

while (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
{
    Console.WriteLine("Por favor, insira um numero positivo (inteiro): ");
    Console.Write("Digite um numero positivo (inteiro):");
}

Console.WriteLine($"Numeros impares até {num} são: ");
for (int i = 1; i <= num; i += 2)
{
    Console.WriteLine(i);
}

Console.WriteLine("Pressione uma tecla para encerrar o programa!");
Console.ReadKey();