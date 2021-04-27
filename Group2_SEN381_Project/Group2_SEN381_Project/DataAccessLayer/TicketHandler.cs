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
        //adds a ticket to the database
        public static void Add(Ticket obj)
        {
            DataAccess access = new DataAccess();
            Ticket ticket = AssignTechnicians(obj);
            access.InsertTicket(ticket.TicketDesc, ticket.TicketLevel, ticket.TicketState, ticket.TicketOpenDate, ticket.TicketCloseDate, ticket.ProblemArea, ticket.ClientID, ticket.TechnitionID, ticket.CallCenterEmpID);

        }

        //assigns an open technician to the ticket.
        public static Ticket AssignTechnicians(Ticket obj)
        {
            string problemArea = obj.ProblemArea;
            int min = int.MaxValue;
            string techID = "";
            DataAccess access = new DataAccess();
            DataTable data = access.GetActiveTickets(problemArea);

            Dictionary<string, int> technicianOpenTickets = new Dictionary<string, int>();

            foreach (DataRow dr in data.Rows)
            {
                technicianOpenTickets.Add(dr["Emp_ID"].ToString(), int.Parse(dr["Total_Open_Tickets"].ToString()));
            }
            foreach (KeyValuePair<string,int> item in technicianOpenTickets)
            {
                if (item.Value < min)
                {
                    min = item.Value;
                    techID = item.Key;
                }
            }

            obj.TechnitionID = techID;
            
            return obj;

        }
        //returns a list of specializations for technician objects
        public static List<Specialization> GetTechnicianSpecs(string empID)
        {
            DataAccess access = new DataAccess();
            List<Specialization> specs = new List<Specialization>();
            DataTable data = access.GetTechSpecializations(empID);

            foreach (DataRow dr in data.Rows)
            {
                specs.Add(new Specialization(dr["Spec_ID"].ToString(), dr["Spec_Name"].ToString(), dr["Spec_Description"].ToString()));
            }

            return specs;
        }

        //Returns a specific ticket based on a ticket-ID
        public static Ticket GetTicket(string ticketID)
	    {
            DataAccess dataAccess = new DataAccess();
            DataTable dataTable = new DataTable();

            dataTable = dataAccess.SearchTicket(ticketID);
            DataRow row = dataTable.Rows[0];

            
            return new Ticket(row[0].ToString(),row[1].ToString(), row[2].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString());
        }

        //Gets list of open tickets for specific Technician
        public static List<Ticket> GetTechOpenTickets(string empID)
        {
            List<Ticket> tickets = new List<Ticket>();
            DataAccess access = new DataAccess();
            DataTable data = access.GetTechOpenTicket(empID);

            foreach(DataRow dr in data.Rows)
            {
                tickets.Add(new Ticket(dr["Ticket_ID"].ToString(), dr["Ticket_Description"].ToString(), dr["Ticket_Level"].ToString(), dr["Ticket_State"].ToString(),dr["Open_Date"].ToString(), dr["Close_Date"].ToString(), dr["Problem_Area"].ToString(), dr["Client_ID"].ToString(), dr["Technician_ID"].ToString(), dr["Call_Center_ID"].ToString()));
            }

            return tickets;
        }

    }
}
