using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MyFirstWebApp.Data;
using MyFirstWebApp.Models;

var builder = WebApplication.CreateBuilder(args);

// MVC
builder.Services.AddControllersWithViews();

// ✅ Connect to LocalDB
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ✅ Add Identity (this automatically registers authentication & cookie schemes)
builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 6;
})
.AddEntityFrameworkStores<ApplicationDbContext>()
.AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.AccessDeniedPath = "/Account/AccessDenied";
});

// ✅ Add session (optional, useful for temporary carts)
builder.Services.AddSession();

var app = builder.Build();

// ✅ Auto apply migrations + seed sample data
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    db.Database.Migrate();

    if (!db.Products.Any())
    {
        db.Products.AddRange(
            new Product { Name = "Smartphone X1", Category = "Mobiles", Price = 499.99M, ImageUrl = "https://unsplash.com/photos/iphone-screen-showing-icons-on-screen-Uae7ouMw91A" },
            new Product { Name = "Laptop Pro", Category = "Laptops", Price = 1099.99M, ImageUrl = "https://via.placeholder.com/350x250?text=Laptop" },
            new Product { Name = "Headphones", Category = "Audio", Price = 199.99M, ImageUrl = "https://via.placeholder.com/350x250?text=Headphones" }
        );
        db.SaveChanges();
    }
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// ✅ These must be in this exact order
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
