using Microsoft.EntityFrameworkCore;
using Notification_AWS;
using Notification_AWS.Helpers;
using Notification_AWS.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<DataContext>();
builder.Services.AddScoped<IFileRepository, FileRepository>();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

IFileRepository service = app.Services.GetRequiredService<IFileRepository>();

app.MapGet("/", async () => await SqsConsumer.Noification(service));

app.Run();
