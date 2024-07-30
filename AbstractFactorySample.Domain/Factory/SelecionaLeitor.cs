using System.Reflection;
using AbstractFactorySample.Domain.Atributos;
using AbstractFactorySample.Domain.Factory.Interfaces;
using AbstractFactorySample.Domain.Leitores.Interfaces;

namespace AbstractFactorySample.Domain.Factory
{
    public abstract class SelecionaLeitor<T>
    {
        public static ILeitor<T>? CriarLeitor(string caminhoArquivo)
        {
            var extensao = Path.GetExtension(caminhoArquivo);

            var lista = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => !x.IsInterface && x.IsAssignableTo(typeof(ILeitorFactory<T>)))
                .Select(x => Activator.CreateInstance(x) as ILeitorFactory<T>);

            var tipoArquivo = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => !x.IsInterface && x.IsAssignableTo(typeof(ILeitor<T>)))
                .FirstOrDefault(x => x.GetCustomAttributes<TipoLeitor>().Any(x => x.Tipo.Equals(extensao)));

            var leitor = lista.FirstOrDefault(x => x!.ConsegueCriarTipo(tipoArquivo));

            return leitor?.CriarLeitor();
        }
    }
}