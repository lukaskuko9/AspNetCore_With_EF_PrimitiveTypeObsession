using Microsoft.AspNetCore.Mvc.ModelBinding;
using NSwag.AspNetCore;
using PrimitiveTypeObsession.WebApi;
using PrimitiveTypeObsession.WebApi.ExceptionHandlers;
using PrimitiveTypeObsession.WebApi.ModelBinderProvider;
using PrimitiveTypeObsession.WebApi.SchemaTypeMappers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.ValueProviderFactories.Add(new QueryStringValueProviderFactory());
  //  options.ValueProviderFactories.Add(new RouteValueProviderFactory());
    options.ModelBinderProviders.Insert(0, new ModelBinderProvider());
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApiDocument(settings =>
    {
        settings.Version = "v1.0";
        settings.SchemaSettings.TypeMappers.Add(new EmailTypeMapper());
        settings.SchemaSettings.TypeMappers.Add(new UserAddressTypeMapper());
        settings.SchemaSettings.TypeMappers.Add(new PhoneNumberTypeMapper());
        settings.SchemaSettings.TypeMappers.Add(new MyGuidTypeMapper());
    }
);
builder.Services.AddExceptionHandler<EmailExceptionHandler>();
builder.Services.AddProblemDetails();

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
app.UseExceptionHandler();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();