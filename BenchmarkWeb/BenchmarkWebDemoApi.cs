using BenchmarkDotNet.Attributes;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDemo;

namespace BenchmarkWebDemo
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class BenchmarkWebDemoApi
    {
        private static HttpClient _httpClient;

        [Params(1, 25, 50)]
        public int N;

        [GlobalSetup]
        public void GlobalSetup()
        {
            var factory = new WebApplicationFactory<IApiMaker>()
                .WithWebHostBuilder(configuration =>
                {
                    configuration.ConfigureLogging(logging =>
                    {
                        logging.ClearProviders();
                    });
                });
            _httpClient = factory.CreateClient();
        }

        [Benchmark]
        public async Task GetProducts()
        {
            for (int i = 0; i < N; i++)
            {
                var response = await _httpClient.GetAsync("/GetProducts");
            }
        }

        [Benchmark]
        public async Task GetProductsOptimized()
        {
            for (int i = 0; i < N; i++)
            {
                var response = await _httpClient.GetAsync("/GetProductsOptimized");
            }
        }
    }

}
