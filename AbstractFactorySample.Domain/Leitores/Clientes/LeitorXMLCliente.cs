using AbstractFactorySample.Domain.Atributos;
using AbstractFactorySample.Domain.Entities;
using AbstractFactorySample.Domain.Leitores.Interfaces;

namespace AbstractFactorySample.Domain.Leitores.Clientes
{
    [TipoLeitor(".xml")]
    public class LeitorXMLCliente : ILeitor<Cliente>
    {
        public void RealizarLeitura()
        {
            //Regra de leitura aqui
            System.Console.WriteLine("Lendo XML cliente ...");
        }
    }
}