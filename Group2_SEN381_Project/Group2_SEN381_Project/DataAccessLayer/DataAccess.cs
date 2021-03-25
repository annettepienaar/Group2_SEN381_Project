using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Group2_SEN381_Project.DataAccessLayer
{
    class DataAccess: IDataAccess
    {
        private readonly string connString;
        private SqlDataAdapter dataAdapter;
        private readonly SqlConnection connection;

        public DataAccess()
        {
            connString = $@"DataSource = .; InitialCatalog = SEN381_Project; IntegratedSecurity = True;";
            connection = new SqlConnection(connString);
        }

        public DataTable GetTable(string tblName)
        {
            DataTable tblEntries;
            string select = $"SELECT * FROM {tblName}";

            dataAdapter = new SqlDataAdapter(select, connection);
            
            return tblEntries;
            
        }

        /*public List<Client> getClient(string client_ID) {
            Method that will get the client and return it as a List
        }*/

        /*public List<Employee> getEmployee(string emp_ID)
        {
            Method that will get the employee and return it as a List
        }*/

        /*public List<ServicePackage> getSP(string ) 
        {
            Method that will get the service package and return it as a List
        }*/

        /*public Call getCallLogs(DateTime, DateTime)
        {
            Method that will get the call log based on the start and end time/date
        }*/

        /*public void addClient(Client)
        {
            Method that adds a Client to the database and Client table
        }*/

        /*public void addEmployee(Employee)
        {
            Method that adds a Employee to the database and Employee table
        }*/

        /*public void addSP(ServicePackage)
        {
            Method that adds a Service Package to the database and ServicePackage table
        }*/

        /*public void addCallLog(Call)
        {
            Method that adds a Call Log to the database and Call table
        }*/

        /*public void modifyClient(Client)
        {
            Method that can update and modify a record in the Client table
        }*/

        /*public void modifyEmployee(Employee)
        {
            Method that can update and modify a record in the Employee table
        }*/

        /*public void modifySP(ServicePackage)
        {
            Method that can update and modify a record in the ServicePackage table
        }*/
    }
}
