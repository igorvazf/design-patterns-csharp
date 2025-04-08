using FactoryMethod;

// Cliente

Veiculo moto = new MotoFactory().CriarVeiculo();
Veiculo carro = new CarroFactory().CriarVeiculo();

Console.WriteLine(moto.ExibirDetalhes());
Console.WriteLine(carro.ExibirDetalhes());
