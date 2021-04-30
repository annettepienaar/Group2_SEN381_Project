using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_SEN381_Project
{
    public class Ticket
    {
        private string ticketID;
        private string ticketDesc;
        private string ticketLevel;
        private string clientID;
        private string technitionID;
        private string callCenterEmpID;
        private string ticketState;
        private string ticketOpenDate;
        private string ticketCloseDate;
        private string problemArea;

        public Ticket(string ticketID, string ticketDesc, string ticketLevel, string ticketState, string ticketOpenDate, string ticketCloseDate, string problemArea, string clientID, string technitionID, string callCenterEmpID)
        {
            this.ticketID = ticketID;
            this.ticketDesc = ticketDesc;
            this.ticketLevel = ticketLevel;
            this.ticketState = ticketState;
            this.ticketOpenDate = ticketOpenDate;
            this.ticketCloseDate = ticketCloseDate;
            this.problemArea = problemArea;
            this.clientID = clientID;
            this.technitionID = technitionID;
            this.callCenterEmpID = callCenterEmpID;
        }

        public string TicketID { get { return ticketID; } set { ticketID = value; } }
        public string TicketDesc { get { return ticketDesc; } set { ticketDesc = value; } }
        public string TicketLevel { get { return ticketLevel; } set { ticketLevel = value; } }
        public string ClientID { get { return clientID; } set { clientID = value; } }
        public string CallCenterEmpID { get { return callCenterEmpID; } set { callCenterEmpID = value; } }
        public string TicketState { get { return ticketState; } set { ticketState = value; } }
        public string TicketOpenDate { get { return ticketOpenDate; } set { ticketOpenDate = value; } }
        public string TicketCloseDate { get { return ticketCloseDate; } set { ticketCloseDate = value; } }
        public string ProblemArea { get { return problemArea; } set { problemArea = value; } }
        public string TechnitionID { get { return technitionID; } set { technitionID = value; } }

        public override bool Equals(object obj)
        {
            return obj is Ticket ticket &&
                   ticketID == ticket.ticketID &&
                   ticketDesc == ticket.ticketDesc &&
                   ticketLevel == ticket.ticketLevel &&
                   clientID == ticket.clientID &&
                   technitionID == ticket.technitionID &&
                   callCenterEmpID == ticket.callCenterEmpID &&
                   ticketState == ticket.ticketState &&
                   ticketOpenDate == ticket.ticketOpenDate &&
                   ticketCloseDate == ticket.ticketCloseDate &&
                   problemArea == ticket.problemArea;
        }

        public override int GetHashCode()
        {
            int hashCode = 1155675649;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ticketID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ticketDesc);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ticketLevel);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clientID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(technitionID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(callCenterEmpID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ticketState);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ticketOpenDate);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ticketCloseDate);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(problemArea);
            return hashCode;
        }

        public override string ToString()
        {
            return $"{TicketID}\t{(TicketOpenDate)}";
        }
    }
}
