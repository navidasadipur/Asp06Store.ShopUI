using Asp06Store.ShopUI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
var cnnString = builder.Configuration.GetConnectionString("StoreCnn");
builder.Services.AddDbContext<StoreDbContext>(options => options.UseSqlServer(cnnString));

builder.Services.AddScoped<IProductRepository, EfProductRepository>();
builder.Services.AddScoped<ICategoryRepository, EfCategoryRepository>();
builder.Services.AddScoped<IOrderRepository, EfOrderRepository>();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<Basket>(c => SessionBasket.GetBasket(c));

builder.Services.AddMemoryCache();
builder.Services.AddSession();

var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("pagination", "/{controller=home}/{action=index}/{category}/page{PageNumber}");
    endpoints.MapControllerRoute("pagination", "/{controller=home}/{action=index}/page{PageNumber}");
    endpoints.MapControllerRoute("pagination", "/{controller=home}/{action=index}/{category}");
    endpoints.MapDefaultControllerRoute();
}
);

app.Run();
