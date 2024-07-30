using AbstractFactorySample.Domain.Leitores.Interfaces;

namespace AbstractFactorySample.Domain.Factory.Interfaces
{
    public interface ILeitorFactory<T>
    {
        bool ConsegueCriarTipo(Type? tipoArquivo);
        ILeitor<T>? CriarLeitor();
    }
}