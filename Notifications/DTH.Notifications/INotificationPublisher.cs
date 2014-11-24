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
        /// Generated when DTH attempts to charge a customer in authorize.net
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="cardExternalId"></param>
        /// <param name="authorizeNetTransactionId"></param>
        /// <param name="amount"></param>
        /// <param name="status"></param>
        /// <param name="currentBalance"></param>
        /// <param name="chargeDate"></param>
        void PublishCycleCharge(string customerId, string cardExternalId, string authorizeNetTransactionId, float amount, string status, float currentBalance, DateTime chargeDate);

        /// <summary>
        /// Generated when One-Time Charge is added to the DTH
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="type"></param>
        /// <param name="amount"></param>
        /// <param name="chargeDate"></param>
        /// <param name="chargeDescription"></param>
        void PublishOneTimeCharge(string customerId, string type, float amount, DateTime chargeDate, string chargeDescription);

        /// <summary>
        /// Generated Credits/Debits are in Web Portal
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="cardExternalId"></param>
        /// <param name="amount"></param>
        /// <param name="transactionType">Credit, De </param>
        /// <param name="currentBalance"></param>
        void PublishTransaction(string customerId, string cardExternalId, float amount, string transactionType, float currentBalance);
    }
}
