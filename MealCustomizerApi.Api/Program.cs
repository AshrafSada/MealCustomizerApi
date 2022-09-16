var builder = WebApplication.CreateBuilder(args);
// services
builder.Services.AddControllers();

// build app
var app = builder.Build();

// hookup middleware
app.UseHttpsRedirection();
app.MapControllers();

// run app
app.Run();