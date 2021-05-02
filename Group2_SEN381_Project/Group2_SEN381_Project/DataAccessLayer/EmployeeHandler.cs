using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Group2_SEN381_Project.BusinessLogicLayer;

namespace Group2_SEN381_Project.DataAccessLayer
{
    static class EmployeeHandler
    {
        public static Employee GetEmployee(string username)
        {
            DataAccess dataAccess = new DataAccess();
            DataTable empTable = dataAccess.GetEmployee(username);
            Employee empObject = null;

            string employee = "";

            char empType = ' ';

            foreach (DataRow emp in empTable.Rows)
            {
                employee = emp.ItemArray[0].ToString();

                empType = employee[0];

                if (empType.Equals('C'))
                {
                    empObject = new CallCentreEmployee(emp.ItemArray[0].ToString(), emp.ItemArray[1].ToString(), emp.ItemArray[2].ToString(), emp.ItemArray[3].ToString(), emp.ItemArray[4].ToString(), emp.ItemArray[5].ToString());
                } else if (empType.Equals('T'))
                {
                    empObject = new TechnicianEmployee(emp.ItemArray[0].ToString(), emp.ItemArray[1].ToString(), emp.ItemArray[2].ToString(), emp.ItemArray[3].ToString(), emp.ItemArray[4].ToString(), emp.ItemArray[5].ToString());
                } else if (empType.Equals('S'))
                {
                    empObject = new SatisfactionEmployee(emp.ItemArray[0].ToString(), emp.ItemArray[1].ToString(), emp.ItemArray[2].ToString(), emp.ItemArray[3].ToString(), emp.ItemArray[4].ToString(), emp.ItemArray[5].ToString());
                } else if (empType.Equals('D'))
                {
                    empObject = new ClientManagementEmployee(emp.ItemArray[0].ToString(), emp.ItemArray[1].ToString(), emp.ItemArray[2].ToString(), emp.ItemArray[3].ToString(), emp.ItemArray[4].ToString(), emp.ItemArray[5].ToString());
                }
                else if (empType.Equals('M'))
                {
                    empObject = new TicketManagementEmployee(emp.ItemArray[0].ToString(), emp.ItemArray[1].ToString(), emp.ItemArray[2].ToString(), emp.ItemArray[3].ToString(), emp.ItemArray[4].ToString(), emp.ItemArray[5].ToString());
                }
            }

            return empObject;
        }

        //Gets table of technicians and turns it into a list
        public static List<TechnicianEmployee> GetTechnicianEmployees()
        {
            DataAccess data = new DataAccess();
            List<TechnicianEmployee> techEmp = new List<TechnicianEmployee>();
            DataTable table = data.GetTechnicians();

            foreach(DataRow dr in table.Rows)
            {
                techEmp.Add(new TechnicianEmployee(dr["Emp_ID"].ToString(), dr["Emp_Name"].ToString(), dr["Emp_Surname"].ToString(), dr["Emp_Address"].ToString(), dr["Emp_Phone"].ToString(), dr["Emp_Password"].ToString()));
            }
            return techEmp;
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
    }
}
