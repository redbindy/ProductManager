using Microsoft.Extensions.Hosting;
using ProductManager;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ProductManager
{
    public class CleanUpService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                // Get the current date and time
                var now = DateTime.UtcNow;

                // If it's midnight, do the clean-up
                if (now.TimeOfDay == TimeSpan.Zero)
                {
                    Manager.Instance.RemoveProduct();
                }

                // Wait for the next second to start
                var nextSecond = now.AddSeconds(1);
                var delay = nextSecond - DateTime.UtcNow;
                await Task.Delay(delay, stoppingToken);
            }
        }
    }
}


