using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group2_SEN381_Project.BusinessLogicLayer;

namespace Group2_SEN381_Project.DataAccessLayer
{
    public static class TicketHandler
    {
        public static void TicketCreation(string desc, string level, string state, string openDate, string closeDate, string problemArea, string clientID, string empID)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.InsertCreationTicket(desc, level, state, openDate, closeDate, problemArea, clientID, empID);
        }
        //adds a ticket to the database
        //public static void Add(Ticket obj)
        //{
        //    DataAccess access = new DataAccess();
        //    Ticket ticket = AssignTechnicians(obj);
        //    access.InsertTicket(ticket.TicketDesc, ticket.TicketLevel, ticket.TicketState, ticket.TicketOpenDate, ticket.TicketCloseDate, ticket.ProblemArea, ticket.ClientID, ticket.TechnitionID, ticket.CallCenterEmpID);

        //}

        //assigns an open technician to the ticket.
        public static void AssignTechnicians(Ticket ticket)
        {
            DataAccess access = new DataAccess();
            access.InsertAssignedTicket(ticket.TicketDesc, ticket.TicketLevel, ticket.TicketState, ticket.TicketOpenDate, ticket.TicketCloseDate, ticket.ProblemArea, ticket.ClientID, ticket.TechnitionID, ticket.CallCenterEmpID);
            access.DeleteUnassignedTicket(ticket.TicketID);
        }
    
        

        //Returns a specific ticket based on a ticket-ID
        public static Ticket GetTicket(string ticketID)
        {
            DataAccess dataAccess = new DataAccess();
            DataTable dataTable = new DataTable();

            dataTable = dataAccess.SearchTicket(ticketID);
            DataRow row = dataTable.Rows[0];


            return new Ticket(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[6].ToString(), DateTime.Parse(row[7].ToString()).ToString("yyyy-MM-dd"), DateTime.Parse(row[8].ToString()).ToString("yyyy-MM-dd"), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString());
        }

        //Gets list of open tickets for specific Technician
        public static List<Ticket> GetTechOpenTickets(string empID)
        {
            List<Ticket> tickets = new List<Ticket>();
            DataAccess access = new DataAccess();
            DataTable data = access.GetTechOpenTicket(empID);

            foreach (DataRow dr in data.Rows)
            {
                tickets.Add(new Ticket(dr["Ticket_ID"].ToString(), dr["Ticket_Description"].ToString(), dr["Ticket_Level"].ToString(), dr["Ticket_State"].ToString(), DateTime.Parse(dr["Open_Date"].ToString()).ToString("yyyy-MM-dd"), DateTime.Parse(dr["Close_Date"].ToString()).ToString("yyyy-MM-dd"), dr["Problem_Area"].ToString(), dr["Client_ID"].ToString(), dr["Technician_ID"].ToString(), dr["Call_Center_ID"].ToString()));
            }

            return tickets;
        }
        //Update Ticket
        public static void UpdateCreatedTicket(Ticket obj)
        {
            DataAccess access = new DataAccess();
            access.UpdateCreatedTicket(obj.TicketID, obj.TicketDesc, obj.TicketLevel, obj.TicketState, obj.ProblemArea, obj.TicketOpenDate, obj.TicketCloseDate, obj.ClientID, obj.CallCenterEmpID);
        }

        public static void UpdateAssignedTicket(Ticket obj)
        {
            DataAccess access = new DataAccess();
            access.UpdateAssignedTicket(obj.TicketID, obj.TicketState, obj.TicketCloseDate);
        }

        public static void EscalateTicket(string ticketID, string ticketDescription, string ticketLevel, string openDate, string closeDate, string problemArea, string clientID, string callCenterID)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.DeleteAssignedTicket(ticketID);

            string ticketState = "On-Hold";

            dataAccess.InsertCreationTicket(ticketDescription, ticketLevel, ticketState, openDate, closeDate, problemArea, clientID, callCenterID);
        }
        //gets all unassigned tickets
        public static List<Ticket> GetUnassignedTickets()
        {
            List<Ticket> unassignedTickets = new List<Ticket>();

            DataAccess data = new DataAccess();
            DataTable unassigned = data.GetUnassignedTickets();

            foreach (DataRow dr in unassigned.Rows)
            {
                unassignedTickets.Add(new Ticket(dr["Ticket_ID"].ToString(), dr["Ticket_Description"].ToString(), dr["Ticket_Level"].ToString(), dr["Ticket_State"].ToString(), dr["Open_Date"].ToString(), dr["Close_Date"].ToString(), dr["Problem_Area"].ToString(), dr["Client_ID"].ToString(), "" , dr["Call_Center_ID"].ToString()));
            }
            return unassignedTickets;
        }

        public static DataTable GetClientTicketTable(string clientID)
        {
            return new DataAccess().GetClientTickets(clientID);
        }

    }
}
