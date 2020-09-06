namespace BenchmarkTest.Mock
{
    public interface IInfoParser
    {
         void SaveInfo(string key, string value);
         (string key, string value) GetInfo();
    }
}