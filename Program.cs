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

app.MapGet("/api/coupon", (ILogger<Program> _logger) =>
{
    _logger.Log(LogLevel.Information, "Getting all coupons");
    return Results.Ok(CouponStore.GetCoupons());
}).WithName("GetCoupons")
  .Produces<IEnumerable<Coupon>>(200);

app.MapGet("/api/coupon/{id:int}", (int id) =>
{
    return Results.Ok(CouponStore.GetCouponById(id));
}).WithName("GetCoupon")
  .Produces<Coupon>(200); ;

app.MapPost("/api/coupon/", ([FromBody] Coupon coupon) =>
{
    if(coupon.Id != 0 || string.IsNullOrEmpty(coupon.Name))
    {
        return Results.BadRequest("Invalid Id or Name");
    }
    else if (CouponStore.CouponExists(coupon) !=null)
    {
        return Results.BadRequest("Coupon already exists");
    };
     CouponStore.CreateCoupon(coupon);
    return Results.CreatedAtRoute("GetCoupon", new {id = coupon.Id}, coupon);

   // return Results.Created($"/api/coupon/{coupon.Id}",coupon);
}).WithName("CreateCoupon")
  .Accepts<Coupon>("application/json")
  .Produces<Coupon>(200)
  .Produces(400);

app.MapPut("/api/coupon/{id:int}", (int id) =>
{
    return Results.Ok(CouponStore.GetCouponById(id));
}).WithName("UpdateCoupon")
  .Produces<Coupon>(201);

app.MapDelete("/api/coupon/{id:int}", (int id) =>
{
    return Results.Ok(CouponStore.GetCouponById(id));
}).WithName("DeleteCoupon"); ;



app.UseHttpsRedirection();

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
