using AbstractFactorySample.Domain.Entities;
using AbstractFactorySample.Domain.Factory.Interfaces;
using AbstractFactorySample.Domain.Leitores.Interfaces;
using AbstractFactorySample.Domain.Leitores.Pets;

namespace AbstractFactorySample.Domain.Factory.Leitores.Pets
{
    public class LeitorPetXMLFactory : ILeitorFactory<Pet>
    {
        public bool ConsegueCriarTipo(Type? tipoArquivo)
        {
            return tipoArquivo?.IsAssignableTo(typeof(LeitorXMLPet)) ?? false;
        }

        public ILeitor<Pet>? CriarLeitor()
        {
            return new LeitorXMLPet();
        }
    }
}