namespace AbstractFactorySample.Domain.Atributos
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TipoLeitor(string tipo) : Attribute
    {
        public string Tipo { get; set; } = tipo;
    }
}