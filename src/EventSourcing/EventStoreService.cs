using EventStore.ClientAPI;
using Microsoft.Extensions.Configuration;

namespace EventSourcing
{
    public class EventStoreService : IEventStoreConnection
    {
        private readonly IEventStoreConnection _connection;

        public EventStoreService(IConfiguration configuration)
        {
            _connection = EventStoreConnection.Create(
                configuration.GetConnectionString("EventStoreConnection"));

            _connection.ConnectAsync();
        }

        public IEventStoreConnection GetStoreConnection()
        {
            return _connection;
        }
        
    }
}