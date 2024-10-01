Console.Write("digite qualquer numero positivo: ");
int numero = int.Parse(Console.ReadLine());
int numero2 = numero * 10;


Console.WriteLine($"\nNumeros de 0 até {numero}");
for (int i = 0; i <= numero2; i += numero)
{
    Console.WriteLine(i);
}

Console.WriteLine("Aperte qualquer tecla para sair! ");
Console.ReadKey();
