using Net6API.Interface;
using Net6API.Utilities;
using Net6API.Validation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyHeader()
              .WithMethods("GET", "POST", "PUT", "DELETE")
              .AllowAnyOrigin()
              .SetPreflightMaxAge(TimeSpan.FromSeconds(2520));
    });
});
builder.Services.AddTransient<ICallApi, CallApi>();
builder.Services.AddTransient<IGeoCoordinateHelper, GeoCoordinateHelper>();
builder.Services.AddTransient<IUserValidation, UserValidation>();
builder.Services.AddTransient<IValidationHelper, ValidationHelper>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseCors();
app.MapControllers();
app.Run();