using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Tresta.Notifications
{
    [DataContract]
    class CycleChargeNotification : TrestaNotification
    {
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

        [DataMember(Name = "authorizeDotNetTransactionId")]
        private string _authorizeDotNetTransactionId;
        public string AuthorizeDotNetTransactionId
        {
            get { return _authorizeDotNetTransactionId; }
            set { _authorizeDotNetTransactionId = value; }
        }

        [DataMember(Name = "amount")]
        private string _amount;
        public string Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        [DataMember(Name = "chargeStatus")]
        private string _chargeStatus;
        public string ChargeStatus
        {
            get { return _chargeStatus; }
            set { _chargeStatus = value; }
        }

        [DataMember(Name = "currentBalance")]
        private string _currentBalance;
        public string CurrentBalance
        {
            get { return _currentBalance; }
            set { _currentBalance = value; }
        }

        [DataMember(Name = "chargeDate")]
        private string _chargeDate;
        public string ChargeDate
        {
            get { return _chargeDate; }
            set { _chargeDate = value; }
        }

        public CycleChargeNotification() : base()
        { }
    }
}
