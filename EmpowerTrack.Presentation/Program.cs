using EmpowerTrack.Application.Mapper;
using EmpowerTrack.Presentation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddHttpContextAccessor(); // Register IHttpContextAccessor
builder.Services.AddAutoMapper(typeof(GlobalMappingProfile));
builder.Services.AddCustomServices(builder.Configuration); // Custom services
builder.Services.AddJwtAuthentication(builder.Configuration); // JWT Authentication
builder.Services.AddCorsPolicy(); // CORS policy

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowReactApp");
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();



