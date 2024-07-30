using AbstractFactorySample.Domain.Entities;
using AbstractFactorySample.Domain.Services.Interfaces;

namespace AbstractFactorySample.Domain.Services
{
    public class ClienteService : IAPIService<Cliente>
    {
        public void CreateAsync(Cliente obj)
        {
            System.Console.WriteLine("Criando cliente ...");
        }

        public void ListAsync()
        {
            System.Console.WriteLine("Listando clientes ...");
        }
    }
}