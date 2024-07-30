using AbstractFactorySample.Domain.Commands.Interfaces;

namespace AbstractFactorySample.Domain.Factory.Interfaces
{
    public interface IFactory
    {
        bool ConsegueCriarTipo(Type? comando);
        IComando CriarComando(string[] argumentos);
    }
}