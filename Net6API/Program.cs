﻿using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Net6API.Data;
using Net6API.Interface;
using Net6API.Utilities;
using Net6API.Validation;
using Net6API.Middleware;
using Net6API.LoggingData;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.ConfigureKestrel((context, options) =>
{
    options.ListenAnyIP(5001, listenOptions =>
    {
        listenOptions.Protocols = HttpProtocols.Http1AndHttp2AndHttp3;
        listenOptions.UseHttps();
    });
    options.ConfigureHttpsDefaults(httpSpec =>
    {
        httpSpec.SslProtocols = System.Security.Authentication.SslProtocols.Tls13;
        httpSpec.OnAuthenticate = (conContext, sslAuthOptions) =>
        {
            sslAuthOptions.CipherSuitesPolicy = CipherSuites.SelectedCipherSuitesPolicy;
        };
    });
});
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
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DB")));
builder.Services.AddDbContext<LogDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("LoggingDB")));
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
app.UseAppException();
app.Run();