namespace Router001.Common.ViRouter
{
    public class ViRoute
    {
        public string Path { get; set; }
        public string Method { get; set; }
        public static string GET = "GET";
        public static string POST = "POST";
        public static string PUTCH = "PUTCH";
        public static string DELETE = "DELETE";
        
        public ViRoute(string path, string method)
        {
            Path = path;
            Method = method;
        }
    }
}