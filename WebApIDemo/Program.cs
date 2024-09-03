var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

//Routing
app.MapGet("/shirts", () =>
{
    return "";
});

app.MapGet("/shirts/{id}", (int id) =>
{
    return $"Retrun shirt with the ID: {id}";
});

app.MapPost("/shirts", () =>
{
    return "Creating a shirt";
});




app.Run();