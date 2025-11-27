using Blazorise;
using Blazorise.Icons.FontAwesome;
using Blazorise.Tailwind;
using Inventra.Plugins.InMemory;
using Inventra.UseCases.Interfaces;
using Inventra.UseCases.Inventories;
using Inventra.UseCases.Inventories.interfaces;
using Inventra.WebApp.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton<IInventoryRepository, InventoryRepository>();

builder.Services.AddTransient<IViewInventoriesBySearchTextUseCase, ViewInventoriesBySearchTextUseCase>();
builder.Services.AddTransient<ISaveInventoryUseCase, SaveInventoryUseCase>();


builder.Services
    .AddBlazorise()
    .AddTailwindProviders()
    .AddFontAwesomeIcons();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
