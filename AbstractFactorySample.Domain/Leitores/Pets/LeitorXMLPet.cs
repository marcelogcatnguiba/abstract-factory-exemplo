using AbstractFactorySample.Domain.Atributos;
using AbstractFactorySample.Domain.Entities;
using AbstractFactorySample.Domain.Leitores.Interfaces;

namespace AbstractFactorySample.Domain.Leitores.Pets
{
    [TipoLeitor(".xml")]
    public class LeitorXMLPet : ILeitor<Pet>
    {
        public void RealizarLeitura()
        {
            System.Console.WriteLine("Lendo XML pets ...");
        }
    }
}