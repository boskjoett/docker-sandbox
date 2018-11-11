using System;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;

namespace WebApp.Repository
{
    public class Repository : IRepository
    {
        private readonly ILogger _logger;
        private ConnectionMultiplexer _redis;

        public Repository(ILogger<Repository> logger)
        {
            _logger = logger;

            try
            {
                _redis = ConnectionMultiplexer.Connect("redis");
            }
            catch (Exception ex)
            {
                _logger.LogError("redis connection exception: " + ex.Message);
            }
        }

        public int GetCounter()
        {
            if (_redis != null)
            {
                IDatabase db = _redis.GetDatabase();
                return int.Parse(db.StringGet("counter"));
            }

            return 0;
        }

        public void IncrementCounter()
        {
            if (_redis != null)
            {
                IDatabase db = _redis.GetDatabase();
                db.StringIncrement("counter");
            }
        }

        public string GetMessage()
        {
            if (_redis != null)
            {
                IDatabase db = _redis.GetDatabase();
                return db.StringGet("message");
            }

            return string.Empty;
        }

        public void SetMessage(string message)
        {
            if (_redis != null)
            {
                IDatabase db = _redis.GetDatabase();
                db.StringSet("message", message);
            }
        }
    }
}
