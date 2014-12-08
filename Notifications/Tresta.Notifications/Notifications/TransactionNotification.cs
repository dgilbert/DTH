using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Tresta.Notifications
{
    [DataContract]
    class TransactionNotification : TrestaNotification
    {
        [DataMember(Name = "transactionId")]
        private string _transactionId;
        public string TransactionId
        {
            get { return _transactionId; }
            set { _transactionId = value; }
        }

        [DataMember(Name = "customerId")]
        private string _customerId;
        public string CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        [DataMember(Name = "cardExternalId")]
        private string _cardExternalId;
        public string CardExternalId
        {
            get { return _cardExternalId; }
            set { _cardExternalId = value; }
        }

        [DataMember(Name = "amount")]
        private string _amount;
        public string Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        [DataMember(Name = "transactionType")]
        private string _transactionType;
        public string TransactionType
        {
            get { return _transactionType; }
            set { _transactionType = value; }
        }

        [DataMember(Name = "currentBalance")]
        private string _currentBalance;
        public string CurrentBalance
        {
            get { return _currentBalance; }
            set { _currentBalance = value; }
        }

        public TransactionNotification() : base()
        { }
    }
}
