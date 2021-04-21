using System;
using Microsoft.AspNetCore.Http;

namespace Router001.Common.ViRouter
{
    public class ViRouteFilter
    {
        public static bool FilterRoutes(HttpContext httpContext)
        {

            // var isRoute = false;
            // isRoute = context.Request.Path.StartsWithSegments("/users") && context.Request.Method == ;
            httpContext.Response.Headers.Add("throughViRouterFilter", new[] { DateTime.Now.ToString() });
            return true;
        }

        public static bool FilterRoutes(HttpContext httpContext, ViRoute viRoute)
        {
            var isRightRoute = httpContext.Request.Path.StartsWithSegments(viRoute.Path) && httpContext.Request.Method == viRoute.Method;
            return isRightRoute;
        }

        public static bool FilterRoutes(HttpContext httpContext, ViRoute[] viRouteArray)
        {
            foreach (var route in viRouteArray)
            {
                if (FilterRoutes(httpContext, route))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool FilterR001WeatherForecastVIPRoutes(HttpContext httpContext)
        {
            var isR001WeatherForecastVIPRoute = false;
            isR001WeatherForecastVIPRoute = FilterRoutes(httpContext, ViListRoutes.R001WeatherForecastVIPRoutes);
            if (isR001WeatherForecastVIPRoute)
            {
                httpContext.Response.Headers.Add("NEEDcheckR001WeatherForecastVIPRouteFilter", new[] { DateTime.Now.ToString() });
            }
            else
            {
                httpContext.Response.Headers.Add("DONTTTTTTTTNEEDcheckR001WeatherForecastVIPRouteFilter", new[] { DateTime.Now.ToString() });
            }
            return isR001WeatherForecastVIPRoute;
        }

    }
}