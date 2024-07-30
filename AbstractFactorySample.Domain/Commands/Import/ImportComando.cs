using AbstractFactorySample.Domain.Commands.Interfaces;

namespace AbstractFactorySample.Domain.Commands.Import
{
    public abstract class ImportComando : IComando
    {
        public void ExecuteCommand()
        {
            RegraComando();
        }

        protected abstract void RegraComando();
    }
}