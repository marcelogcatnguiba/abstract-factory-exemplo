namespace AbstractFactorySample.Domain.Services.Interfaces
{
    public interface IAPIService<T>
    {
        void CreateAsync(T obj);
        void ListAsync();
    }
}