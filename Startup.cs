namespace ProductManager
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHostedService<CleanUpService>();
        }

    }
}
