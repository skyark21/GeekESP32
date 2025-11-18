using System;

namespace MqttServices
{
    public class MqttServices
    {
        private readonly IServiceProvider _provider;

        public MqttServices
            (
            IServiceProvider provider
            )
        {
            _provider = provider;
        }
    }
}
