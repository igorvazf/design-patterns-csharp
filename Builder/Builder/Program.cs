using Builder;

Cozinha cozinha = new();
HamburguerBuilder builder = new();

var xSalada = cozinha.PrepararXSalada(builder);
var xBacon = cozinha.PrepararXBacon(builder);
var xTudo = cozinha.PrepararXTudo(builder);

Console.WriteLine(xSalada.GetDescricao());
Console.WriteLine();
Console.WriteLine(xBacon.GetDescricao());
Console.WriteLine();
Console.WriteLine(xTudo.GetDescricao());