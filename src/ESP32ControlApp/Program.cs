using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;
using System.Threading;
using Main;
using Microsoft.Extensions.Logging;
using nanoFramework.Logging.Debug;

namespace ESP32ControlApp
{
    public class Program
    {
        public static void Main()
        {
            Debug.WriteLine("Hello from nanoFramework!");

            ServiceProvider services = ConfigureServices();
            var application = (MainApplication)services.GetRequiredService(typeof(MainApplication));

            application.Run();
        }

        private static ServiceProvider ConfigureServices()
        {
            return new ServiceCollection()
                .AddSingleton(typeof(MainApplication))
                .AddSingleton(typeof(ILoggerFactory), typeof(DebugLoggerFactory))
                .BuildServiceProvider();
        }
    }
}
