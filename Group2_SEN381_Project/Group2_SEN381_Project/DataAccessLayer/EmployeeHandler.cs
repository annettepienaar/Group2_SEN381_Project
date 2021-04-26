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
                }
            }

            return empObject;
        }
    }
}
