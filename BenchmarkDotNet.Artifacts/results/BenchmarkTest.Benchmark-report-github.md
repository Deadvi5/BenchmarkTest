``` ini

BenchmarkDotNet=v0.12.1, OS=elementary 6
Intel Core i7-2600 CPU 3.40GHz (Sandy Bridge), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.401
  [Host]     : .NET Core 5.0.10 (CoreCLR 5.0.1021.41214, CoreFX 5.0.1021.41214), X64 RyuJIT
  DefaultJob : .NET Core 5.0.10 (CoreCLR 5.0.1021.41214, CoreFX 5.0.1021.41214), X64 RyuJIT


```
|      Method |       Mean |    Error |   StdDev |
|------------ |-----------:|---------:|---------:|
|   Serialize | 1,707.3 ns | 25.20 ns | 22.34 ns |
| BuildString |   147.2 ns |  2.97 ns |  3.42 ns |
