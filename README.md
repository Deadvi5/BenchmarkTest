# BenchmarkTest
 .net benchmark

``` ini

 BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.301
  [Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT

```
|      Method |        Mean |     Error |      StdDev |      Median |
|------------ |------------:|----------:|------------:|------------:|
|   Serialize | 20,239.3 ns | 700.57 ns | 1,941.28 ns | 19,400.0 ns |
| BuildString |    227.6 ns |   3.19 ns |     2.82 ns |    228.0 ns |
