var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "This is Shreyas's website!");

app.Run();
dotnet publish -c Release -o ./publish