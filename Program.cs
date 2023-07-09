using GameIndustry;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
//при первом запросе создает экземапл€р - другие будут  переадрисовыватьс€ к нему - AddScoped
//создаетс€ при каждом обращении создаетс€ новый объект - AddTransient
//на прот€жении всего запроса пользуемс€ одним и тем же объектом класса созданный один раз - AddSingleton
builder.Services.AddSingleton<SingletonService>();
builder.Services.AddTransient<TransientService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
