﻿var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

//Routing
app.MapGet("/shirts", () =>
{
    return "";
});


app.Run();



