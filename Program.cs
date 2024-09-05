using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using Web_Minimal_API.Data;
using Web_Minimal_API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/api/coupon", () =>
{
    return Results.Ok(CouponStore.GetCoupons());
});

app.MapGet("/api/coupon/{id:int}", (int id) =>
{
    return Results.Ok(CouponStore.GetCouponById(id));
});

app.MapPost("/api/coupon/", ([FromBody] Coupon coupon) =>
{
    if(coupon.Id !=null || string.IsNullOrEmpty(coupon.Name))
    {
        return Results.BadRequest("Invalid Id or Name");
    };
    else if()
});

app.MapPut("/api/coupon/{id:int}", (int id) =>
{
    return Results.Ok(CouponStore.GetCouponById(id));
});

app.MapDelete("/api/coupon/{id:int}", (int id) =>
{
    return Results.Ok(CouponStore.GetCouponById(id));
});



app.UseHttpsRedirection();

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
