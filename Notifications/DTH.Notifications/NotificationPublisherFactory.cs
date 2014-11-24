using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace DTH.Notifications
{
    public class NotificationPublisherFactory
    {
        public static INotificationPublisher GetInstance()
        {
            // TODO: store in app.config
            string dllLocation = System.Configuration.ConfigurationSettings.AppSettings.Get("Notification.DLL.Location");
            string typeName = System.Configuration.ConfigurationSettings.AppSettings.Get("Notification.DLL.ClassName");
            return GetInstance(dllLocation, typeName);
        }

        private static INotificationPublisher GetInstance(string dllLocation, string typeName)
        {
            Assembly assembly = Assembly.LoadFrom(dllLocation);
            if(assembly != null)
            {
                object notificationObject = assembly.CreateInstance(typeName);
                if (notificationObject != null)
                {
                    return (INotificationPublisher)notificationObject;
                }
            }
            return null;
        }
    }
}