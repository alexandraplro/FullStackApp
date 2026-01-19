using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ClientApp;

// Program.cs configures the Blazor WebAssembly client application.
// Copilot assisted in validating this setup to ensure the front-end correctly initializes, registers HttpClient, and communicates with the Minimal API back-end.
var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Copilot confirmed that adding the App component here follows the standard Blazor bootstrapping pattern.
builder.RootComponents.Add<App>("#app");

// Copilot recommended including HeadOutlet to support dynamic updates to the <head> section, which is useful for metadata and styling.
builder.RootComponents.Add<HeadOutlet>("head::after");

// Registers HttpClient for API communication.
// Copilot suggested using the HostEnvironment.BaseAddress to ensure the client resolves relative URLs correctly and avoids hardcoding.
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

//
// Copilot helped verify that the default WebAssembly host builder pattern is correct and that no additional configuration was needed for this assignment.
await builder.Build().RunAsync();

