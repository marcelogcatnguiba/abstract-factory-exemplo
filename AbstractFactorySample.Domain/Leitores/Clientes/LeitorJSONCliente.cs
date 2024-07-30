using AbstractFactorySample.Domain.Atributos;
using AbstractFactorySample.Domain.Entities;
using AbstractFactorySample.Domain.Leitores.Interfaces;

namespace AbstractFactorySample.Domain.Leitores.Clientes
{
    [TipoLeitor(".json")]
    public class LeitorJSONCliente : ILeitor<Cliente>
    {
        public void RealizarLeitura()
        {
            System.Console.WriteLine("Lendo arquivo JSON clientes ...");
        }
    }
}