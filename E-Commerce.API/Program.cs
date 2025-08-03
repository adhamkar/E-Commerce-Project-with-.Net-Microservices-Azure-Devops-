using E_Commerce.Infrastructure;
using E_Commerce.Core;
using E_Commerce.API.Middlewares;
using E_Commerce.Core.Mappers;
using System.Text.Json.Serialization;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);


// Ajouter Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddInfrastructure();
builder.Services.AddCore();
// adding controllers
//builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(opt =>
{
    opt.JsonSerializerOptions.Converters.Add(new
        JsonStringEnumConverter());
});
//builder.Services.AddAutoMapper(typeof(UserMappingProfile).Assembly);
builder.Services.AddAutoMapper(cfg => { },
    typeof(UserMappingProfile).Assembly);
builder.Services.AddAutoMapper(cfg => { },
    typeof(RegisterRequestMappingProfile).Assembly);

//builder.Services.AddAutoMapper(cfg =>
//{
//    cfg.AddProfile<UserMappingProfile>();
//    cfg.AddProfile<RegisterRequestMappingProfile>();
//});

//FluentValidation
builder.Services.AddFluentValidationAutoValidation();

//app build
var app = builder.Build();


// Activer Swagger en développement
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseExceptionHandlerMiddleware();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();


//app.MapGet("/", () => "Hello World!");

app.Run();
