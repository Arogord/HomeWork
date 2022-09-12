
namespace HomeWork10_5
{
    internal class AccessLevelAttribute : Attribute
    {
        //каждому работнику назначить свой уровень доступа через атрибут.
        public AccesLevelType accesLevelType { get; }
        //public AccessLevelAttribute() { }
        public AccessLevelAttribute(AccesLevelType accesLevelType) => this.accesLevelType = accesLevelType;
    }
}
