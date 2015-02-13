using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Tresta.Notifications
{
    [DataContract]
    class CreditNoteNotification : TrestaNotification
    {
        [DataMember(Name = "paymentID")]
        private string _paymentId;
        public string PaymentId
        {
            get { return _paymentId; }
            set { _paymentId = value; }
        }

        [DataMember(Name = "customerId")]
        private string _customerId;
        public string CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        [DataMember(Name = "creditNoteType")]
        private string _creditNoteType;
        public string CreditNoteType
        {
            get { return _creditNoteType; }
            set { _creditNoteType = value; }
        }
        
        [DataMember(Name = "amount")]
        private string _amount;
        public string Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        [DataMember(Name = "paymentDate")]
        private string _paymentDate;
        public string PaymentDate
        {
            get { return _paymentDate; }
            set { _paymentDate = value; }
        }

        [DataMember(Name = "Description")]
        private string _paymentDescription;
        public string PaymentDescription
        {
            get { return _paymentDescription; }
            set { _paymentDescription = value; }
        }


        [DataMember(Name = "currentBalance")]
        private string _currentBalance;
        public string CurrentBalance
        {
            get { return _currentBalance; }
            set { _currentBalance = value; }
        }

        [DataMember(Name = "previousBalance")]
        private string _previousBalance;
        public string PreviousBalance
        {
            get { return _previousBalance; }
            set { _previousBalance = value; }
        }

        public CreditNoteNotification() : base()
        { }
    }
}
