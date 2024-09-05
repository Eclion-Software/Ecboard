using Ecboard.Interfaces.Chart;
using Ecboard.Services;
using Ecboard.ViewModel.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddScoped<ChartOptionsService>(); // Servisleri ekleyin


builder.Services.AddScoped<IChartOptions, ChartOptions>(); // IChartOptions'ý ve ChartOptions'ý ekleyin

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
