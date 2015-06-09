using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Tresta.Notifications
{
    [DataContract]
    class ErrorNotification : TrestaNotification
    {
        [DataMember(Name = "errorSource")]
        private string _errorSource;
        public string ErrorSource
        {
            get { return _errorSource; }
            set { _errorSource = value; }
        }

        [DataMember(Name = "errorType")]
        private string _errorType;
        public string ErrorType
        {
            get { return _errorType; }
            set { _errorType = value; }
        }

        [DataMember(Name = "errorMessage")]
        private string _errorMessage;
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }

        [DataMember(Name = "customerId")]
        private string _customerId;
        public string CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        [DataMember(Name = "severity")]
        private string _severity;
        public string Severity
        {
            get { return _severity; }
            set { _severity = value; }
        }
    }
}
