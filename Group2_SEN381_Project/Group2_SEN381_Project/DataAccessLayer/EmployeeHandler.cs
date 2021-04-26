using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Group2_SEN381_Project.DataAccessLayer
{
    class EmployeeHandler
    {
        DataAccess myAccess;
        DataTable employeeTable;

        public EmployeeHandler()
        {
            myAccess = new DataAccess();
            employeeTable = new DataTable();

            employeeTable = myAccess.GetTable("Employee");
        }

        public char EmployeeLogin(string username, string password)
        {
            bool empFound = false;
            string userPassword = "";

            char empType = 'U';

            foreach (DataRow employee in employeeTable.Rows)
            {
                if (username == employee.ItemArray[0].ToString())
                {
                    empFound = true;
                    userPassword = employee.ItemArray[5].ToString();
                }
            }

            if (empFound == true)
            {
                MessageBox.Show("Employee found");

                if (password == userPassword)
                {
                    empType = username[0];
                }
                else
                {
                    MessageBox.Show("Password Incorrect");
                }
            }
            else
            {
                MessageBox.Show("Employee not found");
            }

            return empType;
        }
    }
}
