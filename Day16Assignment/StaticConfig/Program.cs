namespace StaticConfig
{
    internal class ApplicationConfig
    {
        public static string ApplicationName { get; set; }
        public static string Environment { get; set; }

        public static int AccessCount { get; set; }

        public static bool IsInitalized { get; set; }

        static ApplicationConfig()
        {
            ApplicationName = "MyApp";
            Environment = "Development";
            AccessCount = 0;
            IsInitalized = false;

            Console.WriteLine("Static Constructor Executed");

        }

        public static void Initialize(string appName, string environment)
        {
            ApplicationName = appName;
            Environment = environment;
            IsInitalized = true;
            AccessCount++;
        }

        public static string GetConfigurationSummary()
        {
            AccessCount++;
            return $"{ApplicationName} {Environment} {AccessCount} {IsInitalized}";
        }

        public static void ResetConfiguration()
        {
            AccessCount++;
            ApplicationName = "MyApp";
            Environment = "Development";
            IsInitalized = false;
        }
        
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            ApplicationConfig.Initialize("NewApp", "NewEnvironment");
            Console.WriteLine($"{ApplicationConfig.GetConfigurationSummary()}");
            ApplicationConfig.ResetConfiguration();
            Console.WriteLine($"{ApplicationConfig.GetConfigurationSummary()}");

        }
    }
}
