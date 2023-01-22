using BenchmarkingWebDemo.Contract;
using BenchmarkingWebDemo.Repo;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();


app.MapGet("/GetProducts", async (IProductRepository productRepository) =>
{
    return Results.Ok(await productRepository.GetAllProducts());
});
app.MapGet("/GetProductsOptimized", async (IProductRepository productRepository) =>
{
    return Results.Ok(await productRepository.GetAllProductsOptimized());
});

app.Run();