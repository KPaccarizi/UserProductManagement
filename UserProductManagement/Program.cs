using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UserProductManagement.Data;

var builder = WebApplication.CreateBuilder(args);

// Configure services
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Use routing
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Use HTTPS redirection if needed
app.UseHttpsRedirection();

app.MapControllers();

app.Run();
