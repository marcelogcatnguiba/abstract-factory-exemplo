using AbstractFactorySample.Domain.Factory;

var comando = SelecionaComando.CriarComando(args);
comando?.ExecuteCommand();