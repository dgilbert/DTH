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

                publisher.PublishCycleCharge("CHRG-CYCLE", "219806959", "6cbb42547ad1201901624c10b1db1f59", "TRANSID-123456789", 59.95f, "SUCCESS", 100.00f, DateTime.Now, 159.95f);
                publisher.PublishCycleCharge("CHRG-CYCLE", "219806959", "6cbb42547ad1201901624c10b1db1f59", "TRANSID-123456789", 159.95f, "FAIL", 159.95f, DateTime.Now, 159.95f);

                /*
                publisher.PublishOneTimeCharge("CHRG-ONETIME", "123456789", "ONETIMECHARGETYPE", 100.00f, DateTime.Now, "One time charge description", 25.00f, 125.00f);

                publisher.PublishStatementGenerated("STATEMENTGENERATED-ID", "123456789", DateTime.Now, DateTime.Now, @"http://dthapi01-aio10.tresta.com/statements/STATEMENTGENERATED-ID");

                publisher.PublishStatementPosted("STATEMENTPOSTED-ID", "123456789", DateTime.Now, DateTime.Now.AddDays(5), @"http://dthapi01-aio10.tresta.com/statements/STATEMENTPOSTED-ID");

                publisher.PublishTransaction("TRANS-ID", "123456789", Guid.NewGuid().ToString(), 123.00f, "CREDIT", 45.00f, 168.00f);
                
                
                */
                
                publisher.PublishCreditNote("CRDT1000000000000","219806959","MISC", 35.00f, DateTime.Now, "Miscellaneous Credit because I am a nice person!", 0.00f, 35.00f);
                ++i;

            }
            TimeSpan timeDiff = DateTime.Now - start;
            Console.WriteLine("Publishing notifications took {0}", timeDiff.TotalMilliseconds);
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();

        }
    }
}
