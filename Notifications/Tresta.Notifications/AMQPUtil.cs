using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RabbitMQ.Client;

namespace Tresta.Notifications
{
    public class AMQPUtil
    {
        public static void basicPublish(string serverAddress, string exchange, string exchangeType, string routingKey, string payload)
        {
            ConnectionFactory cf = new ConnectionFactory();
            cf.Uri = serverAddress;

            using (IConnection conn = cf.CreateConnection())
            {
                using (IModel ch = conn.CreateModel())
                {
                    if (exchange != "")
                    {
                        ch.ExchangeDeclare(exchange, exchangeType);
                    }
                    
                    IBasicProperties basicProps = ch.CreateBasicProperties();
                    basicProps.ContentType = "application/json";
                    basicProps.DeliveryMode = 2;

                    ch.BasicPublish(exchange,
                                    routingKey,
                                    basicProps,
                                    Encoding.UTF8.GetBytes(payload));
                }
            }
        }
    }
}
