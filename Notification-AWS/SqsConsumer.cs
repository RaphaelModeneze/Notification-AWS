using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;
using Notification_AWS.Models;
using Notification_AWS.Repository;

namespace Notification_AWS
{
    public class SqsConsumer
    {
        private const string quereSQS = "https://sqs.sa-east-1.amazonaws.com/493103478301/My-Stack-StandardQueue-ErjE3wksE1AG";
        public static async Task Noification(IFileRepository fileRepository)
        {
            var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
            var request = new ReceiveMessageRequest
            {
                QueueUrl = quereSQS
            };

            while (true)
            {
                var response = await client.ReceiveMessageAsync(request);

                foreach (var mensagem in response.Messages)
                {
                    Console.WriteLine(mensagem.Body);

                    fileRepository.InsertFile(new Files() { Filename = "", Filesize = "", Last_modified = DateTime.Now });
                    fileRepository.Save();

                    await client.DeleteMessageAsync(quereSQS, mensagem.ReceiptHandle);
                }
            }
        }
    }
}
