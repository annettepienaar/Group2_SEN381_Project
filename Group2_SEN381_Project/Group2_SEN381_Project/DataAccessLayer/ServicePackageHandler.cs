using Group2_SEN381_Project.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_SEN381_Project.DataAccessLayer
{
	static class ServicePackageHandler
	{
		#region Service Package Database-related methods
		//Sends updated Service Package to Database
		public static void UpdateSP(string spID, string spName, string spType, string spPriority, string epName, string epModel, string epSerialnum, string spReleaseDate, string spCloseDate)
		{
			DataAccess dataAccess = new DataAccess();
			dataAccess.UpdateSP(spID, spName, spType, spPriority, epName, epModel, epSerialnum, spReleaseDate, spCloseDate);
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
				spList.Add(new ServicePackage(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString()));
			}

			return spList;
		}

		// Generates a SP_ID and stores an SP
		public static void CreateSP(string spName, string spType, string spPriority, string epName, string epModel, string epSerialNum, string spReleaseDate, string spCloseDate)
		{
			DataAccess dataAccess = new DataAccess();
			string spID;

			#region SP_ID Generator
			spID = spReleaseDate.Substring(0,4);

			switch (spType)
			{
				case "Warrenty":
					spID += "W";
					break;
				case "Annual Servicing":
					spID += "A";
					break;
				case "Bulk Buy":
					spID += "B";
					break;
				default:
					MessageBox.Show("Incorrect Service Package entered.");
					break;
			}

			switch (spPriority)
			{
				case "Copper":
					spID += "A";
					break;
				case "Silver":
					spID += "B";
					break;
				case "Gold":
					spID += "C";
					break;
				case "Platinum":
					spID += "D";
					break;
				default:
					MessageBox.Show("Incorrect Service Priority entered.");
					break;
			}

			// Checks if SP_ID already exists, if true then increase the SP_ID numerical
			string numerical = "0001";
			int numCounter = 2;

			while (dataAccess.SPExists(spID + numerical))
			{
				//Left padding the numerical with 0's
				numerical = numCounter.ToString();
				while (!(numerical.Length == 4))
				{
					numerical = "0" + numerical;
				}
				numCounter += 1;
			}

			spID += numerical;
			#endregion

			dataAccess.InsertSP(spID,spName,spType,spPriority,epName,epModel,epSerialNum,spReleaseDate,spCloseDate);
		}
		#endregion



		//Calculates total subscribers of a SP
		public static string CalcTotalSubscribers(string SP_id)
		{
			string totalSubscribers;
			DataAccess access = new DataAccess();
			totalSubscribers = access.CountSubscribers(SP_id).ToString();
			return totalSubscribers;
		}

	}
}
