string[] vetDiaSemana = new string[]
{

    "Segunda-Feira",  
    "Terça-Feira",    
    "Quarta-Feira",   
    "Quinta-Feira",   
    "Sexta-Feira",   
    "Sábado",         
    "Domigo",         
    
};

string[] tarefas = new string[7];
for (int i = 0; i < tarefas.Length; i++ )
{
    Console.WriteLine($"Insira as tarefas da semana {vetDiaSemana[i]}");
    tarefas[i] = Console.ReadLine();
}

Console.WriteLine("\ntarefas para a semana");
for (int i = 0; i < vetDiaSemana.Length; i++ )
{
    Console.WriteLine($"\n{vetDiaSemana[i]}: {tarefas[i]}");
}


Console.ReadKey();