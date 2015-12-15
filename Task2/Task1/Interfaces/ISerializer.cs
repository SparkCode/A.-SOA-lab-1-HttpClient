namespace Serialization
{
    internal interface ISerializer<in T, out TR>
    {
        TR Serialize(T obj);
    }
}
