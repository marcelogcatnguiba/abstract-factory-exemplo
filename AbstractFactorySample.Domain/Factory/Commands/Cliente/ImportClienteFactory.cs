using AbstractFactorySample.Domain.Commands.Import;
using AbstractFactorySample.Domain.Commands.Interfaces;
using AbstractFactorySample.Domain.Factory.Interfaces;
using AbstractFactorySample.Domain.Services;

namespace AbstractFactorySample.Domain.Factory.Commands.Cliente
{
    public class ImportClienteFactory : IFactory
    {
        public bool ConsegueCriarTipo(Type? comando)
        {
            return comando?.IsAssignableTo(typeof(ImportCliente)) ?? false;
        }

        public IComando CriarComando(string[] argumentos)
        {
            var service = new ClienteService();
            var leitor = SelecionaLeitorCliente.CriarLeitor(argumentos[1]);
            
            if(leitor is not null)
            {
                return new ImportCliente(service, leitor);
            }
            
            throw new Exception();
        }
    }
}