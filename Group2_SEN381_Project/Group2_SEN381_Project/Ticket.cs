using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_SEN381_Project
{
    class Ticket
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

        public Ticket(string ticketID, string ticketDesc, string ticketLevel, string clientID, string technitionID, string callCenterEmpID, string ticketState, string ticketOpenDate, string ticketCloseDate)
        {
            this.ticketID = ticketID;
            this.ticketDesc = ticketDesc;
            this.ticketLevel = ticketLevel;
            this.clientID = clientID;
            this.technitionID = technitionID;
            this.callCenterEmpID = callCenterEmpID;
            this.ticketState = ticketState;
            this.ticketOpenDate = ticketOpenDate;
            this.ticketCloseDate = ticketCloseDate;
        }

        public string TicketID { get { return ticketID; } set { ticketID = value; } }
        public string TicketDesc { get { return ticketDesc; } set { ticketDesc = value; } }
        public string TicketLevel { get { return ticketLevel; } set { ticketLevel = value; } }
        public string ClientID { get { return clientID; } set { clientID = value; } }
        public string CallCenterEmpID { get { return callCenterEmpID; } set { callCenterEmpID = value; } }
        public string TicketState { get { return ticketState; } set { ticketState = value; } }
        public string TicketOpenDate { get { return ticketOpenDate; } set { ticketOpenDate = value; } }
        public string TicketCloseDate { get { return ticketCloseDate; } set { ticketCloseDate = value; } }

    }
}
