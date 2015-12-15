namespace Serialization
{
    internal interface IStringSerializer<T> : ISerializer<T,string>, IDeserializer<string, T>
    {
    }
}
