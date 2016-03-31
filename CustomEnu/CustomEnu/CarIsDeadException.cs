using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CustomEnu
{
    class CarIsDeadException: ApplicationException
    {
        private string messageDetails = string.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException() { }
        public CarIsDeadException(string message, string cause, DateTime datetime) 
        {
            messageDetails = message;
            ErrorTimeStamp = datetime;
            CauseOfError = cause;
        }
        public override string Message
        {
            get
            {

                return string.Format("Car Error Massage: {0}", messageDetails);
            }
        }

    }
}
