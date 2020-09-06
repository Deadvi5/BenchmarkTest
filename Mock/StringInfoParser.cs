namespace BenchmarkTest.Mock
{
    public class StringInfoParser : IInfoParser
    {
        public (string key, string value) GetInfo()
        {
            var result = Database.BuiltString.Split("§");
            return (result[0], result[1]);
        }

        public void SaveInfo(string key, string value)
        {
            Database.BuiltString = $"{key}§{value}";
        }
    }
}