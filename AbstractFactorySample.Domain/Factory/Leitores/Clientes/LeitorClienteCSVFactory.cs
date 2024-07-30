using AbstractFactorySample.Domain.Entities;
using AbstractFactorySample.Domain.Factory.Interfaces;
using AbstractFactorySample.Domain.Leitores.Clientes;
using AbstractFactorySample.Domain.Leitores.Interfaces;

namespace AbstractFactorySample.Domain.Factory.Leitores.Clientes
{
    public class LeitorClienteCSVFactory : ILeitorFactory<Cliente>
    {
        public bool ConsegueCriarTipo(Type? tipoArquivo)
        {
            return tipoArquivo?.IsAssignableTo(typeof(LeitorCSVCliente)) ?? false;
        }

        public ILeitor<Cliente> CriarLeitor()
        {
            return new LeitorCSVCliente();
        }
    }
}