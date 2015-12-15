namespace Serialization
{
    internal interface IDeserializer<in T, out TR>
    {
        TR Deserialize(T obj);
    }
}
