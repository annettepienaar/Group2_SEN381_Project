using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_SEN381_Project.BusinessLogicLayer
{
    class Call
    {
        private string callID, clientID, empID;
        private DateTime callStartTime, callEndTime;

        public Call(string callID, string clientID, string empID, DateTime callStartTime, DateTime callEndTime)
        {
            this.callID = callID;
            this.clientID = clientID;
            this.empID = empID;
            this.callStartTime = callStartTime;
            this.callEndTime = callEndTime;
        }

        public DateTime CallStartTime
        {
            get { return callStartTime; }
            set { callStartTime = value; }
        }

        public DateTime CallEndTime
        {
            get { return callEndTime; }
            set { callEndTime = value; }
        }

        public string ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        public string EmpID
        {
            get { return empID; }
            set { empID = value; }
        }

        public override bool Equals(object obj)
        {
            return obj is Call call &&
                   callID == call.callID &&
                   clientID == call.clientID &&
                   empID == call.empID &&
                   callStartTime == call.callStartTime &&
                   callEndTime == call.callEndTime;
        }

        public override int GetHashCode()
        {
            int hashCode = -2068544720;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(callID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clientID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(empID);
            hashCode = hashCode * -1521134295 + callStartTime.GetHashCode();
            hashCode = hashCode * -1521134295 + callEndTime.GetHashCode();
            return hashCode;
        }
    }
}
