﻿using Group2_SEN381_Project.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_SEN381_Project.DataAccessLayer
{
	static class ServicePackageHandler
	{
		#region Service Package Database-related methods
		//Adds a Service Package into the DB
		public static void AddSP(ServicePackage obj)
		{
			DataAccess dataAccess = new DataAccess();
			dataAccess.InsertSP(obj.SPName, obj.SPDesc, obj.SPReleaseDate, obj.SPCloseDate);
		}


		//Returns a List of all the Service Packages
		public static List<ServicePackage> GetAllSP()
		{
			DataAccess dataAccess = new DataAccess();
			DataTable dataTable = new DataTable();
			List<ServicePackage> spList = new List<ServicePackage>();

			dataTable = dataAccess.GetTable("Service_Package");

			foreach (DataRow row in dataTable.Rows)
			{
				spList.Add(new ServicePackage(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString()));
			}

			return spList;
		}


		public static void UpdateSP(string spID, string spName, string spDesc, string spReleaseDate, string spCloseDate)
		{
			DataAccess dataAccess = new DataAccess();
			dataAccess.UpdateSP(spID, spName, spDesc, spReleaseDate, spCloseDate);
		}
		#endregion

		public static void CalcPerformanc()
		{
			//TO DO
		}

		// Generates the ID for a Service Package
		/*public string GenerateID(ServicePackage sp)
		{
			// Output Example: 2021AB0001
			string year = DateTime.Today.Year.ToString();
			
			string spType = sp.
		
		}*/
	}
}
