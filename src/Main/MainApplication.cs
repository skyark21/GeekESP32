using Microsoft.Extensions.Logging;
using System;

namespace Main
{
    public class MainApplication
    {
        private readonly ILogger _logger;
        private readonly IServiceProvider _provider;

        public MainApplication
            (
            IServiceProvider provider,
            ILoggerFactory loggerFactory
            )
        {
            _provider = provider;
            _logger = loggerFactory.CreateLogger(nameof(MainApplication));

            _logger.LogInformation("MainApplication started.");
        }

        public void Run()
        {
            _logger.LogInformation("MainApplication is running.");
        }
    }
}
