﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace ConsoleCoreReceiver
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello this is the Receiver application!");

            RabbitReceiver receiver = new RabbitReceiver();
            receiver.Connect();
            receiver.Consume();
            
        }

    }
}
