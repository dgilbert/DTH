using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTH.Notifications;

namespace DTH.Notifications.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            // INotificationPublisher test = NotificationPublisherFactory.GetInstance();
            //INotificationPublisher publisher = NotificationPublisher.Instance;
            //publisher.PublishStatementGenerated("123456789", DateTime.Now, DateTime.Now);

            Console.WriteLine("Publishing Messages begin....");
            DateTime start = DateTime.Now;
            for (int i = 0; i < 1000; ++i)
            {
                INotificationPublisher publisher = NotificationPublisher.Instance;
                publisher.PublishStatementGenerated("STMT-010101010101", "123456789", DateTime.Now, DateTime.Now, @"http://dthapi01-aio10.tresta.com/statements/STMT-010101010101");
                ++i;
            }
            TimeSpan timeDiff = DateTime.Now - start;
            Console.WriteLine("Inserting Records done took {0}", timeDiff.TotalMilliseconds);
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

        }
    }
}
