int nota;
Console.Write("Informe a sua nota (de 0 a 100): ");
int.TryParse(Console.ReadLine(), out nota);

if (nota > 89 && nota < 101)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Parabéns você tirou uma nota A!");
    Console.ResetColor();
}
else if (nota > 79 && nota < 90)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Sua nota foi boa você tirou um B!");
    Console.ResetColor();
}
else if (nota > 69 && nota < 80)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Sua nota foi mediana você tirou um C!");
    Console.ResetColor();
}
else if (nota > 59 && nota < 70)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Você precisa estudar mais tirou um D!");
    Console.ResetColor();
}
else if (nota < 60)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Você está de recuperação tirou um F!");
    Console.ResetColor();
}

Console.ReadKey();