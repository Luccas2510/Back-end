Console.WriteLine("Escolha um número de 1 a 12 (cada número indica um mês do ano)");

int numeroEscolhido = int.Parse(Console.ReadLine());

switch (numeroEscolhido)
{
    case 1:
        Console.WriteLine("Esse é o mês de Janeiro o que significa que está no Verão.");
        break;
    case 2:
        Console.WriteLine("Esse é o mês de Fevereiro o que significa que está no Verão.");
        break;
    case 3:
        Console.WriteLine("Esse é o mês de Março o que significa que está no Outono.");
        break;
    case 4:
        Console.WriteLine("Esse é o mês de Abril o que significa que está no Outono.");
        break;
    case 5:
        Console.WriteLine("Esse é o mês de Maio o que significa que está no Outono.");
        break;
    case 6:
        Console.WriteLine("Esse é o mês de Junho o que significa que está na Inverno.");
        break;
    case 7:
        Console.WriteLine("Esse é o mês de Julho o que significa que está no Inverno.");
        break;
    case 8:
        Console.WriteLine("Esse é o mês de Agosto o que significa que está no Inverno.");
        break;
    case 9:
        Console.WriteLine("Esse é o mês de Stembro o que significa que está na Primavera .");
        break;
    case 10:
        Console.WriteLine("Esse é o mês de Outubro o que significa que está no Primavera.");
        break;
    case 11:
        Console.WriteLine("Esse é o mês de Novembro o que significa que está no Primavera.");
        break;
    case 12:
        Console.WriteLine("Esse é o mês de Dezembro o que significa que está no Verão.");
        break;

    default:
        Console.WriteLine("O número escolhido não é permitido");
        break;
}


Console.WriteLine("Precione qualquer tecla para encerrar");
Console.ReadKey();