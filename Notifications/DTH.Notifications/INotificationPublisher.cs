using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTH.Notifications
{
    public interface INotificationPublisher
    {
        /// <summary>
        /// Generated when a statement is generated for a customer
        /// </summary>
        /// <param name="statementId"></param>
        /// <param name="customerId"></param>
        /// <param name="statementGenerated"></param>
        /// <param name="statemenDue"></param>
        /// <param name="statementLink"></param>
        void PublishStatementGenerated(string statementId, string customerId, DateTime statementGenerated, DateTime statemenDue, string statementLink);

        /// <summary>
        /// Generated when a statement is posted for a customer
        /// </summary>
        /// <param name="statementId"></param>
        /// <param name="customerId"></param>
        /// <param name="statementGenerated"></param>
        /// <param name="statemenDue"></param>
        /// <param name="statementLink"></param>
        void PublishStatementPosted(string statementId, string customerId, DateTime statementGenerated, DateTime statemenDue, string statementLink);

        /// <summary>
        /// Generated when DTH attempts to cycle charge a customer in authorize.net
        /// </summary>
        /// <param name="paymentId"></param>
        /// <param name="customerId"></param>
        /// <param name="cardExternalId"></param>
        /// <param name="authorizeNetTransactionId"></param>
        /// <param name="amount"></param>
        /// <param name="status"></param>
        /// <param name="currentBalance"></param>
        /// <param name="chargeDate"></param>
        /// <param name="previousBalance"></param>
        void PublishCycleCharge(string paymentId, string customerId, string cardExternalId, string authorizeNetTransactionId, float amount, string status, float currentBalance, DateTime chargeDate, float previousBalance);

        /// <summary>
        /// Generated when One-Time Charge is added to the DTH
        /// </summary>
        /// <param name="chargeId"></param>
        /// <param name="customerId"></param>
        /// <param name="type"></param>
        /// <param name="amount"></param>
        /// <param name="chargeDate"></param>
        /// <param name="chargeDescription"></param>
        /// <param name="currentBalance"></param>
        /// <param name="previousBalance"></param>
        void PublishOneTimeCharge(string chargeId, string customerId, string type, float amount, DateTime chargeDate, string chargeDescription, float currentBalance, float previousBalance);

        /// <summary>
        /// Generated Credits/Debits are in Web Portal
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="customerId"></param>
        /// <param name="cardExternalId"></param>
        /// <param name="amount"></param>
        /// <param name="transactionType"></param>
        /// <param name="currentBalance"></param>
        /// <param name="previousBalance"></param>
        void PublishTransaction(string transactionId, string customerId, string cardExternalId, float amount, string transactionType, float currentBalance, float previousBalance);
    }
}
