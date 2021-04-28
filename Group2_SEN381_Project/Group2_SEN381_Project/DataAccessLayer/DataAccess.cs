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
                MessageBox.Show("An error has occoured", ex.Message);
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
                MessageBox.Show("An error has occoured", ex.Message);
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
                MessageBox.Show("An error has occoured", ex.Message);
            }
            return tblEntries;
        }
        //Get a list of all active tickets
        public DataTable GetActiveTickets(string problemArea)
        {
            DataTable tblEntries = new DataTable();
            string select = "SELECT E.Emp_ID, ISNULL(E.All_Tickets,0) - ISNULL(A.Closed_Tickets,0) AS Total_Open_Tickets" +
                "FROM(SELECT E.Emp_ID, COUNT(*) AS All_Tickets" +
                    "FROM Employee E" +
                    "INNER JOIN Employee_Specialization ES ON E.Emp_ID = ES.Emp_ID" +
                    "INNER JOIN Specialization S ON S.Spec_ID = ES.Spec_ID" +
                    "INNER JOIN Ticket T ON E.Emp_ID = T.Technician_ID" +
                    $"WHERE S.Spec_Name = '{problemArea}'" +
                    "GROUP BY E.Emp_ID) AS E" +
                "LEFT JOIN(SELECT E.Emp_ID, COUNT(*) AS Closed_Tickets" +
                    "FROM Employee E" +
                    "INNER JOIN Employee_Specialization ES ON E.Emp_ID = ES.Emp_ID" +
                    "INNER JOIN Specialization S ON S.Spec_ID = ES.Spec_ID" +
                    "INNER JOIN Ticket T ON E.Emp_ID = T.Technician_ID" +
                    $"WHERE S.Spec_Name = '{problemArea}' AND T.Close_Date != '1900-01-01'" +
                    "GROUP BY E.Emp_ID) AS A ON A.Emp_ID = E.Emp_ID";
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
        public DataTable GetTechOpenTicket(string empID)
        {

            DataTable tblEntries = new DataTable();
            string select = $"SELECT * FROM Ticket WHERE Technician_ID = '{empID}' AND Close_Date = '1900-01-01'";
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
                MessageBox.Show("An error has occoured", ex.Message);
            }

            return tblEntries;
        }

        public DataTable GetCalls(string clientID)
        {
            string select = $@"SELECT Call_ID AS 'Call ID', Start_Time AS 'Start Time', End_Time AS 'End Time', Emp_ID AS 'Employee ID' FROM [Call] WHERE Client_ID = '{clientID}'";

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
                MessageBox.Show("An error has occurred: ", ex.Message);
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
                MessageBox.Show("An error has occurred: ", ex.Message);
            }
            return dataTable;
        }

        #endregion

        //inserts for employee, client, calls, tickets, service packages
        #region Insert Into Database
        public void InsertEmployee(string id, string name, string surname, string address, string phone)
        {
            try
            {
                connection.Open();
                string insert = $@"INSERT INTO Employees (Emp_ID, Emp_Name, Emp_Surname, Emp_Address, Emp_Phone) VALUES ({id},{name},{surname},{address},{phone})";
                modifyCMD= new SqlCommand(insert, connection);
                modifyCMD.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occoured",ex.Message);
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
                MessageBox.Show("An error has occoured", ex.Message);
            }
            
        }

        public void InsertCall(string startTime, string endTime, string clientID, string empID)
        {
            try
            {
                connection.Open();
                string insert = $@"INSERT INTO Call (Start_Time, End_Time, Client_ID, Emp_ID) VALUES ({startTime},{endTime},{clientID},{empID})";
                modifyCMD = new SqlCommand(insert, connection);
                modifyCMD.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occoured", ex.Message);
            }

        }

        public void InsertTicket( string desc, string level, string state, string openDate, string closeDate, string problemArea, string clientID, string techID, string empID)
        {
            try
            {
                connection.Open();
                string insert = $@"INSERT INTO Ticket (Ticket_Description, Ticket_Level, Ticket_State, Open_Date, Close_Date, Problem_Area, Client_ID, Technician_ID, Call_Centre_ID) VALUES ({desc},{level},{state},{openDate},{closeDate},{problemArea},{clientID}, {techID}, {empID})";
                modifyCMD= new SqlCommand(insert, connection);
                modifyCMD.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occoured", ex.Message);
            }
            
        }

        public void InsertSP(string name, string desc, string releaseDate, string closeDate)
        {
            try
            {
                connection.Open();
                string insert = $@"INSERT INTO Service_Package (Package_Name, Package_Description, Release_Date, Close_Date) VALUES ({name},{desc},{releaseDate},{closeDate})";
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

        //updates for service packages, tickets, employee, client
        #region Update Tables
        public void UpdateSP(string id, string name, string desc, string releaseDate, string closeDate)
        {
            try
            {
                connection.Open();
                string update = $@"UPDATE Service_Package SET Package_Name = {name},Package_Description = {desc},Release_Date = {releaseDate},Close_Date = {closeDate} WHERE SP_ID = {id}";
                modifyCMD = new SqlCommand(update, connection);
                modifyCMD.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occoured", ex.Message);
            }

        }

        public void UpdateTicket(string id, string desc, string level, string state, string openDate, string closeDate, string clientID, string techID, string empID)
        {
            try
            {
                connection.Open();
                string update = $@"UPDATE Ticket SET Ticket_Description = '{desc}',Ticket_Level = '{level}',Ticket_State = '{state}',Open_Date = '{openDate}',Close_Date = '{closeDate}',Client_ID = '{clientID}',Technician_ID = '{techID}',Call_Center_ID = '{empID}' WHERE Ticket_ID = '{id}'";
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
                string update = $@"UPDATE Employees SET Emp_Name = {name},Emp_Surname = {surname},Emp_Address = {address},Emp_Phone = {phone} WHERE Emp_ID = {id}";
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
                string insert = $@"UPDATE Client SET Name = {name},Surname = {surname},Business_Name = {bName},Phone = {phone},Address = {address},SP_ID = {spID} WHERE Client_ID = {id}";
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

        #endregion
    }
}
