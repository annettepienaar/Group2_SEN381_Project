using Group2_SEN381_Project.BusinessLogicLayer;
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
		public static void AddSP(ServicePackage obj)
		{
			DataAccess dataAccess = new DataAccess();
			dataAccess.InsertSP(obj.SPName,obj.SPDesc,obj.SPReleaseDate,obj.SPCloseDate);
		}

		public static List<ServicePackage> GetAllSP()
		{
			DataAccess dataAccess = new DataAccess();
			DataTable dataTable = new DataTable();
			List<ServicePackage> spList = new List<ServicePackage>();

			dataTable = dataAccess.GetTable("Service_Package");

			foreach (DataRow row in dataTable.Rows)
			{
				spList.Add(new ServicePackage(row[0].ToString(),row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString()));
			}

			return spList;
		}

		public static void UpdateSP(string spID, string spName, string spDesc, string spReleaseDate, string spCloseDate)
		{
			DataAccess dataAccess = new DataAccess();
			dataAccess.UpdateSP(spID, spName, spDesc, spReleaseDate, spCloseDate);
		}

		public static void CalcPerformanc()
		{
			//TO DO
		}
	}
}
