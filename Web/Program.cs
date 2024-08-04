using Shared.Service;
using Web.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<ExerciseService>();
builder.Services.AddScoped<TrainingService>();

builder.Services.AddRazorComponents()
.AddInteractiveServerComponents();

builder.Services.AddHttpClient("Api", client => client.BaseAddress = new Uri("https://localhost:7223"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddAdditionalAssemblies(typeof(Shared._Imports).Assembly);

app.Run();
