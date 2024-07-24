using System.Text.Json;

namespace Kama.ApiManagement.Tools;

public class ObjectSerializer : Kama.AppCore.IObjectSerializer
{
    public T Deserialize<T>(string serializedValue)
               => JsonSerializer.Deserialize<T>(serializedValue);

    public string Serialize(object obj)
    {
        if (obj == null)
            return null;

        return JsonSerializer.Serialize(obj);
    }
}