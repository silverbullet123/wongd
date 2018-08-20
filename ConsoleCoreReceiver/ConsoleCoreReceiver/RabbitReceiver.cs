using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace ConsoleCoreReceiver
{
    class RabbitReceiver
    {

        private IConnection connection;
        private IModel channel;

        public void Connect()
        {
            try
            {
                ConnectionFactory factory = new ConnectionFactory
                {
                    HostName = ConnectionConstants.HostName
                };

                connection = factory.CreateConnection();
                channel = connection.CreateModel();
                channel.QueueDeclare(queue: ConnectionConstants.QueueName,
                                         durable: false,
                                         exclusive: false,
                                         autoDelete: false,
                                         arguments: null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Consume()
        {
            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body;
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine(Prompt.ReturnPrompt(message));
            };
            channel.BasicConsume(queue: ConnectionConstants.QueueName,
                                 autoAck: true,
                                 consumer: consumer);
        }
    }
}
