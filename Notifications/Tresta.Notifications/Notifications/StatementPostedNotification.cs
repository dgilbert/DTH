using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Tresta.Notifications
{
    [DataContract]
    class StatementPostedNotification : TrestaNotification
    {
        [DataMember(Name = "statementId")]
        private string _statementId;
        public string StatementId
        {
            get { return _statementId; }
            set { _statementId = value; }
        }

        [DataMember(Name = "customerId")]
        private string _customerId;
        public string CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        [DataMember(Name = "statementPosted")]
        private string _statementPosted;
        public string StatementPosted
        {
            get { return _statementPosted; }
            set { _statementPosted = value; }
        }

        [DataMember(Name = "statementDue")]
        private string _statementDue;
        public string StatementDue
        {
            get { return _statementDue; }
            set { _statementDue = value; }
        }

        [DataMember(Name = "statementLink")]
        private string _statementLink;
        public string StatementLink
        {
            get { return _statementLink; }
            set { _statementLink = value; }
        }

        public StatementPostedNotification() : base()
        { }
    }
}
