using System;
namespace Router001.Common.ViRouter
{
    public static class ViListRoutes
    {
        public static ViRoute[] R001WeatherForecastVIPRoutes = new ViRoute[] {
            new ViRoute("/wfVIP", ViRoute.GET),
            new ViRoute("/wfVIP1000", ViRoute.GET),
            new ViRoute("/wfVIP/users", ViRoute.GET),
        };
        // public static ViRoute[] AuthorizationRoutes = null;

    }
}