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


        }
        public static List<TechnicianEmployee> GetTechnicians(Ticket obj)
        {
            DataAccess access = new DataAccess();
            List<TechnicianEmployee> techEmp = new List<TechnicianEmployee>();
            DataTable data = access.GetTechnicians();

            foreach (DataRow dr in data.Rows)
            {
                techEmp.Add(new TechnicianEmployee(dr["Emp_Address"].ToString(), dr["Emp_ID"].ToString(), dr["Emp_Name"].ToString(), dr["Emp_Surname"].ToString(), dr["Emp_Phone"].ToString()));
            }

            return techEmp;

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
