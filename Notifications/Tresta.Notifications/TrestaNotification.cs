using System;
using System.Text;
using RabbitMQ.Client;
using System.Web;
using System.Configuration;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Tresta.Notifications
{
    [Serializable]
    public class TrestaNotification
    {
        public string toJSON()
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(this.GetType());
            using (MemoryStream ms = new MemoryStream())
            {
                jsonSerializer.WriteObject(ms, this);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }

        public void publish()
        {
            string message = this.toJSON();
            basicPublish(message);
        }

        public static void basicPublish(TrestaNotification notification)
        {
            notification.publish();
        }

        private static void basicPublish(string message)
        {
            string serverAddress = ConfigurationSettings.AppSettings.Get("Tresta.Notifications.serverAddress");
            string exchangeType = ConfigurationSettings.AppSettings.Get("Tresta.Notifications.exchangeType");
            string exchange = ConfigurationSettings.AppSettings.Get("Tresta.Notifications.exchange");
            string routingKey = ConfigurationSettings.AppSettings.Get("Tresta.Notifications.routingKey");
            TrestaNotification.basicPublish(serverAddress, exchange, exchangeType, routingKey, message);
        }
        private static void basicPublish(string serverAddress, string exchange, string exchangeType, string routingKey, string message)
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
                    ch.BasicPublish(exchange,
                                    routingKey,
                                    null,
                                    Encoding.UTF8.GetBytes(message));
                }
            }
        }
    }
}
