using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace IngenSoftFunctionApp
{
    public static class MainFunction
    {
        [FunctionName("MainFunction")]
        public static void Run([QueueTrigger("IngenSoftQueue", Connection = "")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
