using Infrastructure.MyGeneratedClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();
builder.Services.AddTransient<MyGeneratedClient>(serviceProvider =>
    {
        var uri = new Uri("http://localhost:5000");
        var client = serviceProvider.GetRequiredService<IHttpClientFactory>().CreateClient();
        client.BaseAddress = uri;

        return new MyGeneratedClient(client);
    }
);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();