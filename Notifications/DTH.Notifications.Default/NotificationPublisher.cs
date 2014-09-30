using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTH.Notifications;

namespace DTH.Notifications.Default
{
    public class NotificationPublisher : INotificationPublisher
    {
        public void PublishStatementGenerated(string statementId, string accountId, DateTime statementGenerated, DateTime statementDue, string statementLink)
        {
            return;
        }
        public void PublishStatementPosted(string statementId, string customerId, DateTime statementPosted, DateTime statementDue, string statementLink)
        {
            return;
        }
        public void PublishCycleCharge(string customerId, string cardExternalId, string authorizeNetTransactionId, float amount, string status, float currentBalance, DateTime chargeDate)
        {
            return;
        }
        public void PublishOneTimeCharge(string customerId, string type, string amount, string chargeDate, string chargeDescription)
        {
            return;
        }
        public void PublishTransaction(string customerId, string cardExternalId, string amount, string transactionType, float currentBalance)
        {
            return;
        }

    }
}
