using AbstractFactorySample.Domain.Leitores.Interfaces;
using AbstractFactorySample.Domain.Entities;
using AbstractFactorySample.Domain.Atributos;

namespace AbstractFactorySample.Domain.Leitores.Pets
{
    [TipoLeitor(".csv")]
    public class LeitorCSVPet : ILeitor<Pet>
    {
        public void RealizarLeitura()
        {
            System.Console.WriteLine("Lendo CSV pets ...");
        }
    }
}