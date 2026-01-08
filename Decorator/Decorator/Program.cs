using Decorator;
using Decorator.Decorator.Concrete;

ICarro carro = new Carro();
ICarro arDecorator = new ArCondicionadoDecorator(carro);
ICarro bancoDecorator = new BancoDeCouro(arDecorator);
ICarro multimidiaDecorator = new KitMultimidiaDecorator(bancoDecorator);

var retorno = multimidiaDecorator.RetornarCarro();

Console.WriteLine(retorno);
