``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.3208/22H2/2022Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|                                     Method |       Array |       Mean |      Error |     StdDev |     Median | Rank | Allocated |
|------------------------------------------- |------------ |-----------:|-----------:|-----------:|-----------:|-----:|----------:|
| **MedirPerformanceFazerBuscaBinariaRecursiva** | **Int32[1000]** |  **15.089 ns** |  **0.3155 ns** |  **0.2951 ns** |  **15.012 ns** |    **6** |         **-** |
|  MedirPerformanceFazerBuscaLinearIterativa | Int32[1000] | 401.359 ns | 11.9320 ns | 34.4267 ns | 413.638 ns |   10 |         - |
| **MedirPerformanceFazerBuscaBinariaRecursiva** |  **Int32[100]** |   **9.404 ns** |  **0.1722 ns** |  **0.1344 ns** |   **9.363 ns** |    **3** |         **-** |
|  MedirPerformanceFazerBuscaLinearIterativa |  Int32[100] |  43.670 ns |  0.5444 ns |  0.4826 ns |  43.610 ns |    7 |         - |
| **MedirPerformanceFazerBuscaBinariaRecursiva** |   **Int32[10]** |   **4.379 ns** |  **0.0385 ns** |  **0.0342 ns** |   **4.369 ns** |    **1** |         **-** |
|  MedirPerformanceFazerBuscaLinearIterativa |   Int32[10] |   4.614 ns |  0.1105 ns |  0.0979 ns |   4.577 ns |    2 |         - |
| **MedirPerformanceFazerBuscaBinariaRecursiva** |  **Int32[200]** |  **11.413 ns** |  **0.0678 ns** |  **0.0566 ns** |  **11.414 ns** |    **4** |         **-** |
|  MedirPerformanceFazerBuscaLinearIterativa |  Int32[200] |  79.374 ns |  1.6205 ns |  4.5172 ns |  78.100 ns |    8 |         - |
| **MedirPerformanceFazerBuscaBinariaRecursiva** |  **Int32[300]** |  **13.889 ns** |  **0.2918 ns** |  **0.5409 ns** |  **13.791 ns** |    **5** |         **-** |
|  MedirPerformanceFazerBuscaLinearIterativa |  Int32[300] | 111.928 ns |  2.2836 ns |  5.2008 ns | 109.453 ns |    9 |         - |
