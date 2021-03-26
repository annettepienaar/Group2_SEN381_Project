﻿using System;
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


        public DataAccess()
        {
            connString = $@"DataSource = .; InitialCatalog = SEN381_Project; IntegratedSecurity = True;";
            connection = new SqlConnection(connString);

           
        }

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

        //need to insert employee, client, calls, tickets, service packages

        public void InsertEmployee(string id, string name, string surname, string address, string phone)
        {
            try
            {
                connection.Open();
                string insert = $@"INSERT INTO Employees (Emp_ID, Emp_Name, Emp_Surname, Emp_Address, Emp_Phone) VALUES ({id},{name},{surname},{address},{phone})";
                SqlCommand insertcmd = new SqlCommand(insert, connection);
                insertcmd.ExecuteNonQuery();
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
                string insert = $@"INSERT INTO Client (Client_ID, Name, Surname, Business_Name, Phone, Address, SP_ID) VALUES ({id},{name},{surname},{bName},{phone},{address},{spID})";
                SqlCommand insertcmd = new SqlCommand(insert, connection);
                insertcmd.ExecuteNonQuery();
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
                SqlCommand insertcmd = new SqlCommand(insert, connection);
                insertcmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occoured", ex.Message);
            }

        }

        public void InsertTicket( string desc, string level, string state, string openDate, string closeDate, string clientID, string techID, string empID)
        {
            try
            {
                connection.Open();
                string insert = $@"INSERT INTO Ticket (Ticket_Description, Ticket_Level, Ticket_State, Open_Date, Close_Date, Client_ID, Technician_ID, Call_Centre_Emp_ID) VALUES ({desc},{level},{state},{openDate},{closeDate},{clientID}, {techID}, {empID})";
                SqlCommand insertcmd = new SqlCommand(insert, connection);
                insertcmd.ExecuteNonQuery();
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
                string insert = $@"INSERT INTO Service_Program (Package_Name, Package_Description, Release_Date, Close_Date) VALUES ({name},{desc},{releaseDate},{closeDate})";
                SqlCommand insertcmd = new SqlCommand(insert, connection);
                insertcmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occoured", ex.Message);
            }
            
        }



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
