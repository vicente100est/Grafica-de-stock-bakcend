using BakendChart.Models;
using BakendChart.Models.Response;
using Microsoft.EntityFrameworkCore;

string policy = "MyPolicy";

var builder = WebApplication.CreateBuilder(args);
//Inyección de dependencia
builder.Services.AddDbContext<PubContext>();

//Config del CORS (politica)
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policy, builder =>
    {
        builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "127.0.0.1").AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();

//Usal la politica
app.UseCors(policy);

app.MapGet("/", () => "CSS Rules!");
app.MapGet("/stock", async (PubContext context) =>
{
    return await context.Stocks.Select((b) => new StockResponse
    {
        Name = b.BeerId.ToString(),
        Quantity = b.Quantity
    }).ToListAsync();
});

app.Run();
