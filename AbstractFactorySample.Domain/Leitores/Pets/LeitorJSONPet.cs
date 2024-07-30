using AbstractFactorySample.Domain.Atributos;
using AbstractFactorySample.Domain.Entities;
using AbstractFactorySample.Domain.Leitores.Interfaces;

namespace AbstractFactorySample.Domain.Leitores.Pets
{
    [TipoLeitor(".json")]
    public class LeitorJSONPet : ILeitor<Pet>
    {
        public void RealizarLeitura()
        {
            System.Console.WriteLine("Lendo JSON pets ...");
        }
    }
}