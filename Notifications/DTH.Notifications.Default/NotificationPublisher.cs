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
        public void PublishCycleCharge(string paymentId, string customerId, string cardExternalId, string authorizeNetTransactionId, float amount, string status, float currentBalance, DateTime chargeDate, float previousBalance)
        {
            return;
        }
        public void PublishOneTimeCharge(string chargeId, string customerId, string type, float amount, DateTime chargeDate, string chargeDescription, float currentBalance, float previousBalance)
        {
            return;
        }
        public void PublishTransaction(string transactionId, string customerId, string cardExternalId, float amount, string transactionType, float currentBalance, float previousBalance)
        {
            return;
        }
    }
}
