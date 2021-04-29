using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Group2_SEN381_Project.DataAccessLayer
{
    static class CallHandler
    {
        public static DataTable GetCall(string clientID)
        {
            DataAccess dataAccess = new DataAccess();
            DataTable callTable = dataAccess.GetClientCalls(clientID);

            return callTable;
        }

        public static DataTable GetTickets(string clientID)
        {
            DataAccess dataAccess = new DataAccess();
            DataTable ticketTable = dataAccess.GetClientTickets(clientID);

            return ticketTable;
        }

        public static void Call(string startTime, string endTime, string clientID, string empID)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.InsertCall(startTime, endTime, clientID, empID);
        }
    }
}
