using AbstractFactorySample.Domain.Entities;
using AbstractFactorySample.Domain.Factory.Interfaces;
using AbstractFactorySample.Domain.Leitores.Pets;

namespace AbstractFactorySample.Domain.Factory.Leitores.Pets
{
    public class LeitorPetCSVFactory : ILeitorFactory<Pet>
    {
        public bool ConsegueCriarTipo(Type? tipoArquivo)
        {
            return tipoArquivo?.IsAssignableTo(typeof(LeitorCSVPet)) ?? false;
        }

        public Domain.Leitores.Interfaces.ILeitor<Pet>? CriarLeitor()
        {
            return new LeitorCSVPet();
        }
    }
}