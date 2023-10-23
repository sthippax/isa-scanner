namespace ISAScannerAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", policy =>
                policy.WithOrigins("http://localhost:4200", "https://localhost:7204", "http://localhost:5023", "http://bajpc001.gar.corp.intel.com/", "https://sivindicator.intel.com/ISAScannerAPI/")
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials()
                .SetIsOriginAllowed(hostName => true));

                options.AddPolicy("AllowAll",
                   builder => builder.SetIsOriginAllowed(_ => true)
                   .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());
            });
        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });
    }
}
