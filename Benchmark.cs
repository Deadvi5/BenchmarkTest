using System;
using BenchmarkDotNet.Attributes;
using BenchmarkTest.Mock;

namespace BenchmarkTest
{
    public class Benchmark
    {

        private readonly IInfoParser serializer = new SerializerInfoParser();
        private readonly IInfoParser stringBuilder = new StringInfoParser();

        [Benchmark]
        public void Serialize()
        {
            serializer.SaveInfo("testKey","testValue");
            var result = serializer.GetInfo();

            if(result.key == "testKey" && result.value == "testValue")
            return;

            throw new ApplicationException();
        }

        [Benchmark]
        public void BuildString()
        {
            stringBuilder.SaveInfo("testKey","testValue");
            var result = stringBuilder.GetInfo();

            if(result.key == "testKey" && result.value == "testValue")
            return;

            throw new ApplicationException();
        }
    }
}
