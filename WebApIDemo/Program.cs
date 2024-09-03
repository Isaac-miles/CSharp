var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

//Routing
app.MapGet("/shirts", () =>
{
    return "Return All shirts";
});

app.MapGet("/shirts/{id}", (int id) =>
{
    return $"Retrun shirt with the ID: {id}";
});

app.MapPost("/shirts", () =>
{
    return "Creating a shirt";
});

app.MapPut("/shirts/{id}", (int id) =>
{
    return $"Updating shirt with the ID: {id}";

});

app.MapDelete("/shirts/{id}", (int id) =>
{
    return $"Deleting shirt with the ID: {id}";

});

app.Run();