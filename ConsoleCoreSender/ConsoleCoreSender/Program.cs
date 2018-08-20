using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;


namespace ConsoleCoreSender
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello this is the sender application!");
                RabbitSender sender = new RabbitSender();
                sender.Connect();
                sender.DisplayEnterMsg();
                sender.GetNameEntered();
                sender.SendName();
                sender.DisplaySentMessage();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.InnerException.Message);
            }
        }

       
    }
}
