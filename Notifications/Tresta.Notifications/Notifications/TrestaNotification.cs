using System;
using System.Text;
using System.Web;
using System.Configuration;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Tresta.Notifications
{
    [DataContract]
    public class TrestaNotification
    {
        [DataMember(Name = "eventName")]
        private string _eventName;
        public string EventName
        {
            get { return _eventName; }
            set { _eventName = value; }
        }

        [DataMember(Name = "eventCategory")]
        private string _eventCategory;
        public string EventCategory
        {
            get { return _eventCategory; }
            set { _eventCategory = value; }
        }

        public string toJSON()
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(this.GetType());
            using (MemoryStream ms = new MemoryStream())
            {
                jsonSerializer.WriteObject(ms, this);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }

        public TrestaNotification()
        {
            _eventName = this.GetType().Name;
            _eventCategory = "Notificaton";
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
            AMQPUtil.basicPublish(serverAddress, exchange, exchangeType, routingKey, message);
        }
    }
}
