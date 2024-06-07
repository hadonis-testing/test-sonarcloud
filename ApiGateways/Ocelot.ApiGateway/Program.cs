using Serilog;

namespace Ocelot.ApiGateway;

public static class Program
{
    public static void Main(string[] args)
    {
	string un;
	int ab;
	int hiahioa;
	double asdu;
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