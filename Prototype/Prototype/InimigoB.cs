namespace Prototype
{
    // Concrete Prototype
    public class InimigoB : Inimigo, IInimigoPrototype
    {
        public Inimigo ShallowCopy()
        {
            return (Inimigo)this.MemberwiseClone();
        }

        public Inimigo DeepCopy()
        {
            var result = (Inimigo)this.MemberwiseClone();
            result.Arma = new Arma("Faca");
            return result;
        }
    }
}
