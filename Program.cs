using PilhaDinamicaESTUDOS;

Pilha agenda = new Pilha();
agenda.Empilhar("A");
agenda.Empilhar("B");
agenda.Empilhar("C");
agenda.Empilhar("D");
agenda.Empilhar("E");

Console.WriteLine("PRIMEIRA IMPRESSÃO");
agenda.Imprimir();
Console.WriteLine();

agenda.Desempilhar();
Console.WriteLine("IMPRESSÃO após Desenfileirar");
agenda.Imprimir();