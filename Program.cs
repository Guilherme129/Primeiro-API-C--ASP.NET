string[] ola = ["oi ", "tudo ", "bem ", "?"];
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => ola[0] + ola[1] + ola[2] + ola[3]);

app.Run();
