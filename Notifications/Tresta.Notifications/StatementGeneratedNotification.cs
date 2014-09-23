using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;

namespace Tresta.Notifications
{
    [Serializable]
    class StatementGeneratedNotification : TrestaNotification
    {
        private string _statementId;
        public string StatementId
        {
            get { return _statementId; }
            set { _statementId = value; }
        }

        private string _customerId;
        public string CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }
        
        private DateTime _statementGenerated;
        public DateTime StatementGenerated
        {
            get { return _statementGenerated; }
            set { _statementGenerated = value; }
        }

        private DateTime _statementDue;
        public DateTime StatementDue
        {
            get { return _statementDue; }
            set { _statementDue = value; }
        }

        private string _statementLink;
        public string StatementLink
        {
            get { return _statementLink; }
            set { _statementLink = value; }
        }
        
        public StatementGeneratedNotification()
        { }

        public StatementGeneratedNotification(string statementId, string customerId, DateTime statementGenerated, DateTime statementDue, string statementLink)
        {
            this._statementId = statementId;
            this._customerId = customerId;
            this._statementGenerated = statementGenerated;
            this._statementDue = statementDue;
            this._statementLink = statementLink;
        }
    }
}
