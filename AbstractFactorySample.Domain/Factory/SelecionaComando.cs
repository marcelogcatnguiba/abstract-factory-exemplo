using System.Reflection;
using AbstractFactorySample.Domain.Atributos;
using AbstractFactorySample.Domain.Commands.Interfaces;
using AbstractFactorySample.Domain.Factory.Interfaces;

namespace AbstractFactorySample.Domain.Factory
{
    public static class SelecionaComando
    {
        public static IComando? CriarComando(string[] argumentos)
        {
            if(argumentos is null || argumentos.Length.Equals(0))
            {
                return null;
            }
            var comando = argumentos[0];

            var lista = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => !x.IsInterface && x.IsAssignableTo(typeof(IFactory)))
                .Select(x => Activator.CreateInstance(x) as IFactory);

            var tipo = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => !x.IsInterface && !x.IsAbstract && x.IsAssignableTo(typeof(IComando)))
                .FirstOrDefault(x => x.GetCustomAttributes<TipoComando>().Any(x => x.Comando.Equals(comando)));
            
            var fabrica = lista!.FirstOrDefault(x => x!.ConsegueCriarTipo(tipo));

            if(fabrica is null)
                return null;
            
            return fabrica.CriarComando(argumentos);
        }
    }
}