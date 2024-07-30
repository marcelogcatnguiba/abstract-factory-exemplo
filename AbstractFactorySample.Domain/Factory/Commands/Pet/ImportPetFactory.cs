using AbstractFactorySample.Domain.Commands.Import;
using AbstractFactorySample.Domain.Commands.Interfaces;
using AbstractFactorySample.Domain.Factory.Interfaces;

namespace AbstractFactorySample.Domain.Factory.Commands.Pet
{
    public class ImportPetFactory : IFactory
    {
        public bool ConsegueCriarTipo(Type? comando)
        {
            return comando?.IsAssignableTo(typeof(ImportPet)) ?? false;
        }

        public IComando CriarComando(string[] argumentos)
        {
            var leitor = SelecionaLeitorPet.CriarLeitor(argumentos[1]);

            if(leitor is not null)
            {
                return new ImportPet(leitor);
            }

            throw new Exception();
        }
    }
}