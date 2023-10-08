using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Starting_Project.APIs;
using Starting_Project.Data;
using Starting_Project.Data.Repo;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services.AddScoped<IProgramDetailsRepository, ProgramDetailsRepository>();
builder.Services.AddScoped<IAppFormRepository, AppFormRepository>();
builder.Services.AddScoped<AppDb, AppDb>();
builder.Services.AddTransient<ProgramController>();
builder.Services.AddTransient<AppController>();
builder.Services.AddTransient<WorkflowController>();
builder.Services.AddTransient<PreviewController>();

using IHost host = builder.Build();
APITest(host.Services);
await host.RunAsync();

static async void APITest(IServiceProvider hostProvider)
{
    using IServiceScope serviceScope = hostProvider.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;



    #region  Tab A - Program Details APIs call
    var programController = provider.GetRequiredService<ProgramController>();
    var programDetailsModels = await programController.GetAllProgramDetails();

    Console.WriteLine(programDetailsModels);
    #endregion

    #region Tab B - Application Form
    var formController = provider.GetRequiredService<AppController>();
    var forr = await formController.GetAllFormDetails();

    Console.WriteLine(forr);
    #endregion
}