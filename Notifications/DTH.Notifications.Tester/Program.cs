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
            Console.WriteLine("Publishing Messages begin....");
            DateTime start = DateTime.Now;
            for (int i = 0; i < 1; ++i)
            {
                INotificationPublisher publisher = NotificationPublisher.Instance;

                publisher.PublishCycleCharge("CHRG-CYCLE", "123456789", "1111111111", "TRANSID-123456789", 59.95f, "APPROVED", 0.00f, DateTime.Now, 59.95f);

                publisher.PublishOneTimeCharge("CHRG-ONETIME", "123456789", "ONETIMECHARGETYPE", 100.00f, DateTime.Now, "One time charge description");

                publisher.PublishStatementGenerated("STATEMENTGENERATED-ID", "123456789", DateTime.Now, DateTime.Now, @"http://dthapi01-aio10.tresta.com/statements/STATEMENTGENERATED-ID");

                publisher.PublishStatementPosted("STATEMENTPOSTED-ID", "123456789", DateTime.Now, DateTime.Now.AddDays(5), @"http://dthapi01-aio10.tresta.com/statements/STATEMENTPOSTED-ID");

                publisher.PublishTransaction("TRANS-ID", "123456789", Guid.NewGuid().ToString(), 123.00f, "CREDIT", 45.00f, 168.00f);
                
                ++i;
            }
            TimeSpan timeDiff = DateTime.Now - start;
            Console.WriteLine("Publishing notifications took {0}", timeDiff.TotalMilliseconds);
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();

        }
    }
}
