using Domain = AbstractFactorySample.Domain.Entities;
using AbstractFactorySample.Domain.Factory.Interfaces;
using AbstractFactorySample.Domain.Leitores.Interfaces;
using AbstractFactorySample.Domain.Leitores.Clientes;

namespace AbstractFactorySample.Domain.Factory.Leitores.Clientes
{
    public class LeitorClienteJSONFactory : ILeitorFactory<Domain::Cliente>
    {
        public bool ConsegueCriarTipo(Type? tipoArquivo)
        {
            return tipoArquivo?.IsAssignableTo(typeof(LeitorJSONCliente)) ?? false;
        }

        public ILeitor<Domain::Cliente>? CriarLeitor()
        {
            return new LeitorJSONCliente();
        }
    }
}