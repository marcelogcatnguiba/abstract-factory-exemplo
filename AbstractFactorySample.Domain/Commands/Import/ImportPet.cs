using AbstractFactorySample.Domain.Atributos;
using AbstractFactorySample.Domain.Entities;
using AbstractFactorySample.Domain.Leitores.Interfaces;

namespace AbstractFactorySample.Domain.Commands.Import
{
    [TipoComando("import-pet")]
    public class ImportPet(ILeitor<Pet> leitor) : ImportComando
    {
        private readonly ILeitor<Pet> _leitor = leitor;
        protected override void RegraComando()
        {
            _leitor.RealizarLeitura();
            System.Console.WriteLine("Import pet ...");
        }
    }
}