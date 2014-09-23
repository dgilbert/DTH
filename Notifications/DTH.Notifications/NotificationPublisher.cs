using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTH.Notifications
{
    public sealed class NotificationPublisher
    {
        private NotificationPublisher()
        { }
        private static INotificationPublisher _instance = NotificationPublisherFactory.GetInstance();

        public static INotificationPublisher Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
