using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Tresta.Notifications
{
    [DataContract]
    class OneTimeChargeNotification : TrestaNotification
    {
        [DataMember(Name = "chargeId")]
        private string _chargeId;
        public string ChargeId
        {
            get { return _chargeId; }
            set { _chargeId = value; }
        }

        [DataMember(Name = "customerId")]
        private string _customerId;
        public string CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        [DataMember(Name = "chargeType")]
        private string _chargeType;
        public string ChargeType
        {
            get { return _chargeType; }
            set { _chargeType = value; }
        }

        [DataMember(Name = "amount")]
        private string _amount;
        public string Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        [DataMember(Name = "chargeDate")]
        private string _chargeDate;
        public string ChargeDate
        {
            get { return _chargeDate; }
            set { _chargeDate = value; }
        }

        [DataMember(Name = "chargeDescription")]
        private string _chargeDescription;
        public string ChargeDescription
        {
            get { return _chargeDescription; }
            set { _chargeDescription = value; }
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

        public OneTimeChargeNotification() : base()
        { }
    }
}
