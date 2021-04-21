using Microsoft.AspNetCore.Builder;
using Router001.Middlewares;

namespace Router001.Extensions
{
    public static class R001ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseR001WeatherForecastVIP(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<R001WeatherForecastVIPMiddleware>();
        }
    }
}