using Prototype;

// Client

InimigoA inimigo1 = new();
inimigo1.Nome = "I1";
inimigo1.Cor = "Azul";
inimigo1.Arma = new Arma("Faca");

Inimigo inimigo2 = new InimigoA();
inimigo2 = inimigo1.ShallowCopy();

Inimigo inimigo3 = new InimigoA();
inimigo3 = inimigo1.DeepCopy();

Console.WriteLine($"Inimigo1 Arma: {inimigo1.Arma.Nome}");
Console.WriteLine($"Inimigo2 Arma: {inimigo2.Arma?.Nome}");
Console.WriteLine($"Inimigo3 Arma: {inimigo3.Arma?.Nome}");
Console.WriteLine();

inimigo1.Arma.Nome = "Espada";

Console.WriteLine($"Inimigo1 Arma: {inimigo1.Arma.Nome}");
Console.WriteLine($"Inimigo2 Arma: {inimigo2.Arma?.Nome}");
Console.WriteLine($"Inimigo3 Arma: {inimigo3.Arma?.Nome}");
