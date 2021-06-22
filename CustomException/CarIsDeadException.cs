using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    //custom exception descibe thE details Of the car-is-dead condition
    //(remember, you can also simply extend exception.

    class CarIsDeadException :ApplicationException
    {
        private string msgDetails = string.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        //constuctor
        public CarIsDeadException()
        {
        }
        public CarIsDeadException(string message, string causeOfError, DateTime timeOfError)
        {
            msgDetails = message;
            CauseOfError = causeOfError;
            ErrorTimeStamp = timeOfError;

            
        }

        //override the system.message property
        public override string Message => $"Car Error Message: {msgDetails}";



    }
}
