using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTH.Notifications;

namespace Tresta.Notifications
{
    class NotificationPublisher : INotificationPublisher
    {        
        public void PublishStatementGenerated(string statementId, string customerId, DateTime statementGenerated, DateTime statementDue, string statementLink)
        {
            StatementGeneratedNotification statementGeneratedNotification = new StatementGeneratedNotification();
            statementGeneratedNotification.StatementId = statementId;
            statementGeneratedNotification.CustomerId = customerId;
            statementGeneratedNotification.StatementGenerated = statementGenerated.ToString("o");
            statementGeneratedNotification.StatementDue = statementDue.ToString("o");
            statementGeneratedNotification.StatementLink = statementLink;
            statementGeneratedNotification.publish();
        }

        public void PublishStatementPosted(string statementId, string customerId, DateTime statementPosted, DateTime statementDue, string statementLink)
        {
            LobbyPushPdfStatement lobbyPushPdfStatement = new LobbyPushPdfStatement();
            lobbyPushPdfStatement.PutStatement(statementId, customerId, statementPosted, statementLink);
            
            StatementPostedNotification statementPostedNotification = new StatementPostedNotification();
            statementPostedNotification.StatementId = statementId;
            statementPostedNotification.CustomerId = customerId;
            statementPostedNotification.StatementPosted = statementPosted.ToString("o");
            statementPostedNotification.StatementDue = statementDue.ToString("o");
            statementPostedNotification.StatementLink = statementLink;
            statementPostedNotification.publish();
        }

        public void PublishCycleCharge(string paymentId, string customerId, string cardExternalId, string authorizeNetTransactionId, float amount, string status, float currentBalance, DateTime chargeDate, float previousBalance)
        {
            CycleChargeNotification cycleChargeNotification = new CycleChargeNotification();
            cycleChargeNotification.PaymentId = paymentId;
            cycleChargeNotification.CustomerId = customerId;
            cycleChargeNotification.CardExternalId = cardExternalId;
            cycleChargeNotification.AuthorizeDotNetTransactionId = authorizeNetTransactionId;
            cycleChargeNotification.Amount = amount.ToString("0.00");
            cycleChargeNotification.ChargeStatus = status;
            cycleChargeNotification.CurrentBalance = currentBalance.ToString("0.00");
            cycleChargeNotification.ChargeDate = chargeDate.ToString("o");
            cycleChargeNotification.PreviousBalance = previousBalance.ToString("0.00");
            cycleChargeNotification.publish();
        }

        public void PublishOneTimeCharge(string chargeId, string customerId, string type, float amount, DateTime chargeDate, string chargeDescription, float currentBalance, float previousBalance)
        {
            OneTimeChargeNotification oneTimeChargeNotification = new OneTimeChargeNotification();
            oneTimeChargeNotification.ChargeId = chargeId;
            oneTimeChargeNotification.CustomerId = customerId;
            oneTimeChargeNotification.ChargeType = type;
            oneTimeChargeNotification.Amount = amount.ToString("0.00");
            oneTimeChargeNotification.ChargeDate = chargeDate.ToString("o");
            oneTimeChargeNotification.ChargeDescription = chargeDescription;
            oneTimeChargeNotification.CurrentBalance = currentBalance.ToString("0.00");
            oneTimeChargeNotification.PreviousBalance = previousBalance.ToString("0.00");
            oneTimeChargeNotification.publish();
        }

        public void PublishTransaction(string transactionId, string customerId, string cardExternalId, float amount, string transactionType, float currentBalance, float previousBalance)
        {
            TransactionNotification transactionNotification = new TransactionNotification();
            transactionNotification.TransactionId = transactionId;
            transactionNotification.CustomerId = customerId;
            transactionNotification.CardExternalId = cardExternalId;
            transactionNotification.Amount = amount.ToString("0.00");
            transactionNotification.TransactionType = transactionType;
            transactionNotification.CurrentBalance = currentBalance.ToString("0.00");
            transactionNotification.PreviousBalance = previousBalance.ToString("0.00");
            transactionNotification.publish();
        }

        public void PublishCreditNote(string paymentId, string customerId, string creditNoteType, float amount, DateTime paymentDate, string paymentDescription, float currentBalance, float previousBalance)
        {
            CreditNoteNotification creditNoteNotification = new CreditNoteNotification();
            creditNoteNotification.PaymentId = paymentId;
            creditNoteNotification.CustomerId = customerId;
            creditNoteNotification.CreditNoteType = creditNoteType;
            creditNoteNotification.Amount = amount.ToString("0.00");
            creditNoteNotification.PaymentDate = paymentDate.ToString("o");
            creditNoteNotification.PaymentDescription = paymentDescription;
            creditNoteNotification.CurrentBalance = currentBalance.ToString("0.00");
            creditNoteNotification.PreviousBalance = previousBalance.ToString("0.00");
            creditNoteNotification.publish();
        }

        public void PublishError(string errorSource, string errorMessage, string customerId, string severity)
        {
            ErrorNotification errorNotification = new ErrorNotification();
            errorNotification.ErrorSource = errorSource;
            errorNotification.ErrorMessage = errorMessage;
            errorNotification.CustomerId = customerId;
            errorNotification.Severity = severity;
            errorNotification.publish();
        }
    }
}
