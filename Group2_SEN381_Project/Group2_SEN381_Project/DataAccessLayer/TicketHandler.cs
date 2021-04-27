using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_SEN381_Project.DataAccessLayer
{
    static class TicketHandler
    {
        //public static void Add(Ticket obj)
        //{
        //    DataAccess dataAccess = new DataAccess();
        //    dataAccess.InsertTicket(obj.TicketDesc,obj.TicketLevel,obj.TicketState,obj.TicketOpenDate,obj.TicketCloseDate,obj.ClientID, ,obj.CallCenterEmpID);
        //}

        //Returns a specific ticket based on a ticket-ID
        public static Ticket GetTicket(string ticketID)
		{
            DataAccess dataAccess = new DataAccess();
            DataTable dataTable = new DataTable();

            dataTable = dataAccess.SearchTicket(ticketID);
            DataRow row = dataTable.Rows[0];

            return new Ticket(row[0].ToString(),row[1].ToString(), row[2].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
        }
    }
}
