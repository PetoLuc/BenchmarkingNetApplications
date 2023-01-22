using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using BenchmarkWebDemo;

var summary = BenchmarkRunner.Run<BenchmarkWebDemoApi>(new DebugInProcessConfig());
