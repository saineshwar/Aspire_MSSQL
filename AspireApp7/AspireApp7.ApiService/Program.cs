using AspireApp7.ApiService.Data;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

// Add API Documentation
builder.Services.AddSwaggerGen();

// Add controllers services
builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddProblemDetails();

// Microsoft SQL Server Connection
builder.AddSqlServerDbContext<DataDbContext>("aspiredatabase");

var app = builder.Build();

// MapControllers is used to map the controllers to the application.
app.MapControllers();

// Register the Swagger generator and the Swagger UI middlewares
app.UseSwagger();

// Enable middleware to serve generated Swagger as a JSON endpoint.
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

app.MapDefaultEndpoints();

app.Run();
