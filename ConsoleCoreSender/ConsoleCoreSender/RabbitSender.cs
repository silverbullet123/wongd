using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using RabbitMQ.Client;

namespace ConsoleCoreSender
{
    public class RabbitSender
    {
        private IConnection connection;
        private IModel channel;
        private byte[] body;
        private string msg;
        

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
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DisplayEnterMsg()
        {
            try
            {
                Console.WriteLine(Prompt.DisplayEnterMsg());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GetNameEntered()
        {
            try
            {
                msg = Console.ReadLine();
                msg = "Hello my name is, " + msg;
                body = Encoding.UTF8.GetBytes(msg);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void SendName()
        {
            try
            {
                channel.BasicPublish(exchange: "",
                                         routingKey: ConnectionConstants.QueueName,
                                         basicProperties: null,
                                         body: body);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DisplaySentMessage()
        {
            try
            {
                Console.WriteLine(Prompt.DisplaySentMessage(msg));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
    }
}
