using NSwag.AspNetCore;
using PrimitiveTypeObsession.WebApi;
using PrimitiveTypeObsession.WebApi.DocumentProcessors;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApiDocument(settings =>
    {
        settings.Version = "v1.0";
        settings.DocumentProcessors.Add(new UserTokenDocumentProcessor());
        settings.DocumentProcessors.Add(new AccountTokenDocumentProcessor());
        settings.DocumentProcessors.Add(new ProcessingTokenDocumentProcessor());
    }
);
DiConfig.ConfigureServices(builder.Services, builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUi(options =>
    {
        options.DocumentTitle = "My Open API";
        options.SwaggerRoutes.Add(new SwaggerUiRoute("v1", "/swagger/v1/swagger.json"));
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();