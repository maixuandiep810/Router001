using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Router001.Middlewares
{
    public class R001WeatherForecastVIPMiddleware
    {
        private readonly RequestDelegate _next;
        public R001WeatherForecastVIPMiddleware(RequestDelegate next) => _next = next;
        public async Task Invoke(HttpContext httpContext)
        {
            if (CheckAccess() == false)
            {
                await Task.Run(
                  async () =>
                  {
                      string html = "<h1>CAM KHONG DUOC TRUY CAP</h1>";
                      httpContext.Response.StatusCode = StatusCodes.Status403Forbidden;
                      httpContext.Response.Headers.Add("DONTthroughVIPMiddleware", new[] { DateTime.Now.ToString() });
                      await httpContext.Response.WriteAsync(html);
                  }
                );
            }
            else
            {
                // Thiết lập Header cho HttpResponse
                httpContext.Response.Headers.Add("throughVIPMiddleware", new[] { DateTime.Now.ToString() });
                // Chuyển Middleware tiếp theo trong pipeline
                await _next(httpContext);

            }
        }

        private bool CheckAccess()
        {
            return false;
        }
    }
}