namespace AbstractFactorySample.Domain.Atributos
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TipoComando(string comando) : Attribute
    {
        public string Comando { get; set; } = comando;
    }
}