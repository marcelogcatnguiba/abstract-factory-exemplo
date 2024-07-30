using AbstractFactorySample.Domain.Atributos;
using AbstractFactorySample.Domain.Commands.Interfaces;

namespace AbstractFactorySample.Domain.Commands.Import
{
    [TipoComando("list-cliente")]
    public class ListCliente : IComando
    {
        public void ExecuteCommand()
        {
            System.Console.WriteLine("listando clientes ...");
        }
    }
}