using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using BenchmarkingConsoleDemo;

//other wayst to execute test
//var summary = BenchmarkRunner.Run(typeof(Program).Assembly, new DebugInProcessConfig());
//var summary = BenchmarkRunner.Run(typeof(BenchmarkLINQPerformance));

//LINQ vs While
//var summary = BenchmarkRunner.Run<BenchmarkLINQPerformance>(new DebugInProcessConfig());

//string builder
var summary = BenchmarkRunner.Run<BenchmarkStringBuilderPerformance>(new DebugInProcessConfig());


