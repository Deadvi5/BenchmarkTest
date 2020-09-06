using System.Collections.Generic;
using System.Text.Json;

namespace BenchmarkTest.Mock
{
    public class SerializerInfoParser : IInfoParser
    {
        public (string key, string value) GetInfo()
        {
            var result = JsonSerializer.Deserialize<KeyValuePair<string,string>>(Database.SerializedString);
            return (result.Key, result.Value);
        }

        public void SaveInfo(string key, string value)
        {
            KeyValuePair<string,string> kvp = new KeyValuePair<string, string>(key,value);
            Database.SerializedString = JsonSerializer.Serialize(kvp);
        }
    }
}