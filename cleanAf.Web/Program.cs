

using cleanAf.Application.Services;
using cleanAf.infrastructure.Persistence;
using cleanAf.infrastructure.Repositories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<UserService>();
builder.Services.AddDbContext<ApplicationDbContext>(
        options => options.UseSqlServer("**connectionString**")); // tu peux aussi placer la constring dans les seccrets ou appsetings et utiliser : Configuration.getSection(**key**);
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
var app = builder.Build();



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
