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
            DataTable callTable = dataAccess.GetCalls(clientID);

            return callTable;
        }
    }
}
