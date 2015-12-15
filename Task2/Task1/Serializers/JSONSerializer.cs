using System.Web.Script.Serialization;

namespace Serialization
{
    internal class JsonSerializer<T> : IStringSerializer<T>
    {
        public string Serialize(T obj)
        {
            var serializer = new JavaScriptSerializer();
            var result = serializer.Serialize(obj);

            return result;
        }

        public T Deserialize(string json)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Deserialize<T>(json);
        }
    }
}
