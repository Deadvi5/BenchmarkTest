# BenchmarkTest
 .net benchmark

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Core i7-2600 CPU 3.40GHz (Sandy Bridge), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.401
  [Host]     : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT


```
|      Method |       Mean |    Error |   StdDev |
|------------ |-----------:|---------:|---------:|
|   Serialize | 2,521.9 ns | 45.56 ns | 70.93 ns |
| BuildString |   199.1 ns |  3.87 ns |  4.76 ns |
