using AbstractFactorySample.Domain.Commands.Import;
using AbstractFactorySample.Domain.Commands.Interfaces;
using AbstractFactorySample.Domain.Factory.Interfaces;

namespace AbstractFactorySample.Domain.Factory.Commands.Cliente
{
    public class ListClienteFactory : IFactory
    {
        public bool ConsegueCriarTipo(Type? comando)
        {
            return comando?.IsAssignableTo(typeof(ListCliente)) ?? false;
        }

        public IComando CriarComando(string[] argumentos)
        {
            return new ListCliente();
        }
    }
}