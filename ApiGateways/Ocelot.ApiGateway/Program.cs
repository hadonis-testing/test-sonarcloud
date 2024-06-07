using Serilog;

namespace Ocelot.ApiGateway;

public static class Program
{
    public static void Main(string[] args)
    {
	string message = "Hello You";
	System.Console.WriteLine(message);
        CreateHostBuilder(args).Build().Run();
    }

    private static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((env, config) =>
            {
                config.AddJsonFile($"ocelot.{env.HostingEnvironment.EnvironmentName}.json", true, true);
            }).ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            }).UseSerilog(Common.Logging.Logging.ConfigureLogger);
}