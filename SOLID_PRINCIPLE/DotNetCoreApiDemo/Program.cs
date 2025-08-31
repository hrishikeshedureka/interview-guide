using DotNetCoreApiDemo;
using DotNetCoreApiDemo.services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add localization services
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

//add dependency
builder.Services.AddSingleton<IOperation, Operation>();
builder.Services.AddScoped<IOperation, Operation>();
builder.Services.AddTransient<IOperation, Operation>();

builder.Services.AddSingleton<ISingletonService, OperationService>();
builder.Services.AddScoped<IScopedService, OperationService>();
builder.Services.AddTransient<ITransientService, OperationService>();

//builder.Services.AddScoped<IGUID, GuidService>();
//builder.Services.AddTransient<IGUID, GuidService>();
builder.Services.AddSingleton<IGUID, GuidService>();

var app = builder.Build();

//supported cultures
var supportedCultures = new[] {"en","fr" };
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture("en")
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization(localizationOptions);


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
