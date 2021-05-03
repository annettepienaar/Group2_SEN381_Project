using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Group2_SEN381_Project.DataAccessLayer
{
    class DataAccess
    {
        private readonly string connString;
        private SqlDataAdapter dataAdapter;
        private readonly SqlConnection connection;
        private SqlCommand modifyCMD;

        public DataAccess()
        {
            //connString = $@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = SEN381_Project; Integrated Security = True;";
            connString = $@"Data Source = .; Initial Catalog = SEN381_Project; Integrated Security = True;";
            connection = new SqlConnection(connString);
        }

        //Gets for all, technician, specialization, technician specializations, active tickets, open tickets, employee, call
        #region Get  Methods
        
        //Gets count of subscribers to a Service Package
        public int CountSubscribers(string id)
        {
            int count;
            string select = $"SELECT COUNT(*) FROM Client WHERE SP_ID = '{id}'";
            
            using (connection)
            {
                using (modifyCMD = new SqlCommand(select, connection))
                {
                    connection.Open();
                    count = (int)modifyCMD.ExecuteScalar();
                }
            }
            return count;            
            
        }

        //Gets the table of specified tableName
        public DataTable GetTable(string tblName)
        {
            DataTable tblEntries = new DataTable();
            string select = $"SELECT * FROM {tblName}";
            try
            {
                dataAdapter = new SqlDataAdapter(select, connection);
                dataAdapter.Fill(tblEntries);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error has occoured");
            }
            return tblEntries;
        }
        //Gets all technician employees and there specialization
        public DataTable GetTechnicians()
        {
            DataTable tblEntries = new DataTable();
            string select = $"SELECT * FROM Employee WHERE Emp_ID LIKE 'T%'";
            try
            {
                dataAdapter = new SqlDataAdapter(select, connection);
                dataAdapter.Fill(tblEntries);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error has occoured");
            }
            return tblEntries;
        }
        //Get specializations of each technician

        public DataTable GetTechSpecializations(string empID)
        {
            DataTable tblEntries = new DataTable();
            string select = $"SELECT S.Spec_ID, S.Spec_Name, S.Spec_Description  FROM Specialization S INNER JOIN Employee_Specialization ES ON ES.Spec_ID = S.Spec_ID WHERE ES.Emp_ID = '{empID}'";
            try
            {
                dataAdapter = new SqlDataAdapter(select, connection);
                dataAdapter.Fill(tblEntries);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error has occoured");
            }
            return tblEntries;
        }

        //Gets Open tickets
        public DataTable GetTechOpenTicket(string empID)
        {

            DataTable tblEntries = new DataTable();
            string select = $"SELECT * FROM Assigned_Ticket WHERE Technician_ID = '{empID}' AND Close_Date = '1900-01-01'";
            try
            {
                dataAdapter = new SqlDataAdapter(select, connection);
                dataAdapter.Fill(tblEntries);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error has occoured");
            }
            return tblEntries;
        }

        //Gets employees based on employee id
        public DataTable GetEmployee(string username)
        {
            string select = $@"SELECT * FROM Employee WHERE Emp_ID = '{username}'";

            DataTable tblEntries = new DataTable();

            try
            {
                dataAdapter = new SqlDataAdapter(select, connection);
                dataAdapter.Fill(tblEntries);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error has occoured");
            }

            return tblEntries;
        }

        //Get unassigned tickets for ticketManagementTable
        public DataTable GetUnassignedTickets()
        {
            string select = $@"SELECT * FROM Created_Ticket";

            DataTable tblEntries = new DataTable();

            try
            {
                dataAdapter = new SqlDataAdapter(select, connection);
                dataAdapter.Fill(tblEntries);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error has occoured");
            }

            return tblEntries;
        }

        //Gets tickets based on client id
        public DataTable GetClientTickets(string clientID)
        {
            string select = $@"SELECT Assigned_Ticket.Open_Date AS 'Open Date', Assigned_Ticket.Close_Date AS 'Close Date', Assigned_Ticket.Ticket_ID AS 'ID', CONCAT(Employee.Emp_Name, ' ', Employee.Emp_Surname) AS 'Employee', Assigned_Ticket.Problem_Area AS 'Problem Area', Assigned_Ticket.Ticket_State AS 'State'
                            FROM Employee
                            JOIN Assigned_Ticket
                            ON Employee.Emp_ID = Assigned_Ticket.Call_Center_ID
                            WHERE Assigned_Ticket.Client_ID = '{clientID}'";

            DataTable tblEntries = new DataTable();

            try
            {
                dataAdapter = new SqlDataAdapter(select, connection);
                dataAdapter.Fill(tblEntries);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occoured", ex.Message);
            }

            return tblEntries;
        }

        //Gets client calls based on client id
        public DataTable GetClientCalls(string clientID)
        {
            string select = $@"SELECT [Call].Call_ID AS 'Call ID', [Call].Start_Time AS 'Start Time', [Call].End_Time AS 'End Time', CONCAT(Employee.Emp_Name, ' ', Employee.Emp_Surname) AS 'Employee'
                            FROM Employee
                            JOIN [Call]
                            ON Employee.Emp_ID = [Call].Emp_ID
                            WHERE [Call].Client_ID = '{clientID}'";

            DataTable tblEntries = new DataTable();

            try
            {
                dataAdapter = new SqlDataAdapter(select, connection);
                dataAdapter.Fill(tblEntries);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occoured", ex.Message);
            }

            return tblEntries;
        }
        #endregion

        //Search for client, client id, ticker, service package
        #region Search Methods
        //Client search
        public DataTable SearchClient(string id)
        {
            DataTable data = new DataTable();
            string select = $"SELECT * FROM Client WHERE Client_ID = '{id}'";
            try
            {
                dataAdapter = new SqlDataAdapter(select, connection);
                dataAdapter.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error has occoured");
            }
            return data;
        }

        //Find the last client for new one to be added
        public string FindClientId()
        {
            string newId = "";
            using (connection)
            {
                connection.Open();
                string select = $"SELECT Top 1 * FROM Client ORDER BY Client_ID DESC";
                using (modifyCMD = new SqlCommand(select, connection))
                {
                    SqlDataReader data = modifyCMD.ExecuteReader();
                    if (data.Read())
                    {
                        newId = data.GetValue(0).ToString();
                    }
                    return newId;
                }               
            }            
        }

        //Ticket Search
        public DataTable SearchTicket(string ticketID)
		{
            DataTable dataTable = new DataTable();
            string query = $"SELECT * FROM Ticket WHERE Ticket_ID = '{ticketID}'";

			try
			{
                dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(dataTable);
			}
			catch (Exception ex)
			{
                MessageBox.Show(ex.Message, "An error has occurred: ");
			}
            return dataTable;
		}

        //Search service package
        public DataTable SearchSP(string spName)
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT SP_ID FROM Service_Package WHERE SP_Name = '{spName}'";

            try
            {
                dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error has occurred: ");
            }
            return dataTable;
        }

        //Check if service package ID exists
        public bool SPExists(string spID)
		{
            DataTable dataTable = new DataTable();
            string query = $"SELECT SP_ID FROM Service_Package WHERE SP_ID = '{spID}'";

            try
            {
                dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: ", ex.Message);
            }

            return (dataTable.Rows.Count > 0);
        }
        #endregion

        //inserts for employee, client, calls, tickets, service packages
        #region Insert Into Database
        public void InsertEmployee(string id, string name, string surname, string address, string phone)
        {
            try
            {
                connection.Open();
                string insert = $@"INSERT INTO Employee (Emp_ID, Emp_Name, Emp_Surname, Emp_Address, Emp_Phone) VALUES ('{id}','{name}','{surname}','{address}','{phone}')";
                modifyCMD= new SqlCommand(insert, connection);
                modifyCMD.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error has occoured");
            }
            
        }

        public void InsertClient(string id, string name, string surname, string bName, string phone, string address ,string spID)
        {
            try
            {
                connection.Open();
                string insert = $@"INSERT INTO Client (Client_ID, Name, Surname, Business_Name, Phone, Address, SP_ID) VALUES ('{id}','{name}','{surname}','{bName}','{phone}','{address}','{spID}')";
                modifyCMD = new SqlCommand(insert, connection);
                modifyCMD.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error has occoured");
            }
            
        }

        public void InsertCall(string startTime, string endTime, string clientID, string empID)
        {
            try
            {
                connection.Open();
                string insert = $@"INSERT INTO Call (Start_Time, End_Time, Client_ID, Emp_ID) VALUES ('{startTime}','{endTime}','{clientID}','{empID}')";
                modifyCMD = new SqlCommand(insert, connection);
                modifyCMD.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error has occoured");
            }

        }

        public void InsertCreationTicket(string desc, string level, string state, string openDate, string closeDate, string problemArea, string clientID, string empID)
        {
            try
            {
                connection.Open();
                string insert = $@"INSERT INTO Created_Ticket (Ticket_Description, Ticket_Level, Ticket_State, Open_Date, Close_Date, Problem_Area, Client_ID, Call_Center_ID) VALUES ('{desc}', '{level}', '{state}', '{openDate}', '{closeDate}', '{problemArea}', '{clientID}', '{empID}')";
                modifyCMD= new SqlCommand(insert, connection);
                modifyCMD.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occoured", ex.Message);
            }            
        }

        public void InsertAssignedTicket(string desc, string level, string state, string openDate, string closeDate, string problemArea, string clientID, string techID, string callCenterID)
        {
            try
            {
                connection.Open();
                string insert = $@"INSERT INTO Assigned_Ticket (Ticket_Description, Ticket_Level, Ticket_State, Open_Date, Close_Date, Problem_Area, Client_ID, Technician_ID, Call_Center_ID) VALUES ('{desc}', '{level}', '{state}', '{openDate}', '{closeDate}', '{problemArea}', '{clientID}', '{techID}', '{callCenterID}')";
                modifyCMD = new SqlCommand(insert, connection);
                modifyCMD.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occoured", ex.Message);
            }
        }

        public void InsertSP(string id, string name, string type, string priority, string epName, string epModel, string epSerialnum, string releaseDate, string closeDate)
        {
            try
            {
                connection.Open();
                string insert = $@"INSERT INTO Service_Package (SP_ID, SP_Name, SP_Type, SP_Priority, EP_Name, EP_Model, EP_SerialNum, SP_Release_Date, SP_Close_Date) VALUES ('{id}','{name}','{type}','{priority}','{epName}','{epModel}','{epSerialnum}','{releaseDate}','{closeDate}')";
                SqlCommand insertcmd = new SqlCommand(insert, connection);
                insertcmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error has occoured");
            }
            
        }

        #endregion

        //updates for service packages, tickets, employee, client
        #region Update Tables
        public void UpdateSP(string id, string name, string type, string priority, string epName, string epModel, string epSerialnum, string releaseDate, string closeDate)
        {
            try
            {
                connection.Open();
                string update = $@"UPDATE Service_Package SET SP_Name = '{name}',SP_Type = '{type}', SP_Priority = '{priority}', EP_Name = '{epName}', EP_Model = '{epModel}', EP_SerialNum = '{epSerialnum}', SP_Release_Date = '{releaseDate}', SP_Close_Date = '{closeDate}' WHERE SP_ID = '{id}'";
                modifyCMD = new SqlCommand(update, connection);
                modifyCMD.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occoured", ex.Message);
            }

        }

        public void UpdateTicket(string ticketID, string desc, string level, string state, string problemArea, string openDate, string closeDate, string clientID,  string callCenterID)
        {
            try
            {
                connection.Open();
                string update = $@"UPDATE Created_Ticket SET Ticket_Description = '{desc}',Ticket_Level = '{level}',Ticket_State = '{state}',Problem_Area = '{problemArea}',Open_Date = '{openDate}',Close_Date = '{closeDate}',Client_ID = '{clientID}' ,Call_Center_ID = '{callCenterID}' WHERE Ticket_ID = '{ticketID}'";
                modifyCMD = new SqlCommand(update, connection);
                modifyCMD.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occoured", ex.Message);
            }

        }

        public void UpdateEmployee(string id, string name, string surname, string address, string phone)
        {
            try
            {
                connection.Open();
                string update = $@"UPDATE Employee SET Emp_Name = {name},Emp_Surname = {surname},Emp_Address = {address},Emp_Phone = {phone} WHERE Emp_ID = {id}";
                modifyCMD = new SqlCommand(update, connection);
                modifyCMD.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occoured", ex.Message);
            }

        }

        public void UpdateClient(string id, string name, string surname, string bName, string phone, string address, string spID)
        {
            try
            {
                connection.Open();
                string insert = $@"UPDATE Client SET Name = '{name}',Surname = '{surname}',Business_Name = '{bName}',Phone = '{phone}',Address = '{address}',SP_ID = '{spID}' WHERE Client_ID = '{id}'";
                SqlCommand insertcmd = new SqlCommand(insert, connection);
                insertcmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occoured", ex.Message);
            }

        }

        #endregion

        //deletes 
        #region Delete Info in Tables
        public void DeleteEmployee(string id) 
        {
            try
            {
                connection.Open();
                string delete = $@"DELETE FROM Employee WHERE Emp_ID = {id}";
                modifyCMD = new SqlCommand(delete, connection);
                modifyCMD.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occoured", ex.Message);
            }
        }
        public void DeleteClient(string id) 
        {
            try
            {
                connection.Open();
                string delete = $@"DELETE FROM Client WHERE Client_ID = {id}";
                modifyCMD = new SqlCommand(delete, connection);
                modifyCMD.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occoured", ex.Message);
            }
        }
        public void DeleteSP(string id) 
        {
            try
            {
                connection.Open();
                string delete = $@"DELETE FROM Service_Package WHERE SP_ID = {id}";
                modifyCMD = new SqlCommand(delete, connection);
                modifyCMD.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occoured", ex.Message);
            }
        }

        public void DeleteAssignedTicket(string ticketID)
        {
            try
            {
                connection.Open();
                string delete = $@"DELETE FROM Assigned_Ticket WHERE Ticket_ID = '{ticketID}'";
                modifyCMD = new SqlCommand(delete, connection);
                modifyCMD.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occoured", ex.Message);
            }
        }

        public void DeleteUnassignedTicket(string ticketID)
        {
            try
            {
                connection.Open();
                string delete = $@"DELETE FROM Created_Ticket WHERE Ticket_ID = '{ticketID}'";
                modifyCMD = new SqlCommand(delete, connection);
                modifyCMD.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occoured", ex.Message);
            }
        }

        #endregion
    }
}
