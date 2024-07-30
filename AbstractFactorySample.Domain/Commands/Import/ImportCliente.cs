using AbstractFactorySample.Domain.Atributos;
using AbstractFactorySample.Domain.Entities;
using AbstractFactorySample.Domain.Leitores.Interfaces;
using AbstractFactorySample.Domain.Services.Interfaces;

namespace AbstractFactorySample.Domain.Commands.Import
{
    [TipoComando("import-clientes")]
    public class ImportCliente(
        IAPIService<Cliente> service,
        ILeitor<Cliente> leitor) : ImportComando
    {
        private readonly IAPIService<Cliente> _service= service;
        private readonly ILeitor<Cliente> _leitor = leitor;

        protected override void RegraComando()
        {
            _leitor.RealizarLeitura();
            _service.CreateAsync(new Cliente());
            System.Console.WriteLine("Import cliente ...");
        }
    }
}