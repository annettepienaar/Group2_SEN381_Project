using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_SEN381_Project.BusinessLogicLayer
{
	public class ServicePackage
	{
		private string spID, spName, spDesc, spReleaseDate, spCloseDate;

		public ServicePackage(string spID, string spName, string spDesc, string spReleaseDate, string spCloseDate)
		{
			this.spID = spID;
			this.spName = spName;
			this.spDesc = spDesc;
			this.spReleaseDate = spReleaseDate;
			this.spCloseDate = spCloseDate;
		}

		public string SPID { get => spID; set => spID = value; }
		public string SPName { get => spName; set => spName = value; }
		public string SPDesc { get => spDesc; set => spDesc = value; }
		public string SPReleaseDate { get => spReleaseDate; set => spReleaseDate = value; }
		public string SPCloseDate { get => spCloseDate; set => spCloseDate = value; }


		public override bool Equals(object obj)
		{
			return obj is ServicePackage package &&
				   spID == package.spID &&
				   spName == package.spName &&
				   spDesc == package.spDesc &&
				   spReleaseDate == package.spReleaseDate &&
				   spCloseDate == package.spCloseDate;
		}

		public override int GetHashCode()
		{
			int hashCode = 1399883183;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(spID);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(spName);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(spDesc);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(spReleaseDate);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(spCloseDate);
			return hashCode;
		}
	}
}
