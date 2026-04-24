using DAL;
using MedicalSocity.Components;

var builder = WebApplication.CreateBuilder(args);

// Add Razor Components
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// DAL services
builder.Services.AddScoped<SocietyInfoDAL>();
builder.Services.AddScoped<AnnualGatheringDAL>();
builder.Services.AddScoped<AnnualProgramDAL>();
builder.Services.AddScoped<CabinetDAL>();
builder.Services.AddScoped<LeadershipDAL>();
builder.Services.AddScoped<PastPresidentDAL>();
builder.Services.AddScoped<SocietyObjectivesDAL>();

var app = builder.Build();

// Error handling
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAntiforgery();

// Map Blazor
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// ✅ FIX HERE
if (builder.Environment.IsDevelopment())
{
    app.Run(); // local
}
else
{
    var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";
    app.Run($"http://0.0.0.0:{port}"); // Render
}