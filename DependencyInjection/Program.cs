using DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ITransientService, OperationService>();
builder.Services.AddScoped<IScopedService, OperationService>();
builder.Services.AddSingleton<ISingletonService, OperationService>();
var app = builder.Build();


//app.MapGet("/", () => "Hello World!");
app.MapDefaultControllerRoute();

app.Run();
