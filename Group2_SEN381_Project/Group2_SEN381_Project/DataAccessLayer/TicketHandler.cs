using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group2_SEN381_Project.BusinessLogicLayer;
using System.Data;

namespace Group2_SEN381_Project.DataAccessLayer
{
    public static class TicketHandler
    {

        public static void Add(Ticket obj)
        {
            DataAccess access = new DataAccess();
            TicketHandler.AssignTechnicians(obj);

        }
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

    }
}
