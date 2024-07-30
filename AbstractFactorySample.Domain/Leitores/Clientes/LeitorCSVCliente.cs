using AbstractFactorySample.Domain.Atributos;
using AbstractFactorySample.Domain.Entities;
using AbstractFactorySample.Domain.Leitores.Interfaces;

namespace AbstractFactorySample.Domain.Leitores.Clientes
{
    [TipoLeitor(".csv")]
    public class LeitorCSVCliente : ILeitor<Cliente>
    {
        public void RealizarLeitura()
        {
            System.Console.WriteLine("Lendo arquivo CSV de cliente ...");
        }
    }
}