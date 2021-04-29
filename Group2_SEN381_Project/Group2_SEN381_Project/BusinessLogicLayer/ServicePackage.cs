using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_SEN381_Project.BusinessLogicLayer
{
	public class ServicePackage
	{
		private string spID, spName, spType, spPriority, epName, epModel, epSerialnum, spReleaseDate, spCloseDate;

		public ServicePackage(string spID, string spName, string spType, string spPriority, string epName, string epModel, string epSerialnum, string spReleaseDate, string spCloseDate)
		{
			this.spID = spID;
			this.spName = spName;
			this.spType = spType;
			this.spPriority = spPriority;
			this.epName = epName;
			this.epModel = epModel;
			this.epSerialnum = epSerialnum;
			this.spReleaseDate = spReleaseDate;
			this.spCloseDate = spCloseDate;
		}

		public string SPID { get => spID; set => spID = value; }
		public string SPName { get => spName; set => spName = value; }
		public string SPType { get => spType; set => spType = value; }
		public string SPPriority { get => spPriority; set => spPriority = value; }
		public string EPName { get => epName; set => epName = value; }
		public string EPModel { get => epModel; set => epModel = value; }
		public string EPSerialnum { get => epSerialnum; set => epSerialnum = value; }
		public string SPReleaseDate { get => spReleaseDate; set => spReleaseDate = value; }
		public string SPCloseDate { get => spCloseDate; set => spCloseDate = value; }

        public override bool Equals(object obj)
        {
            return obj is ServicePackage package &&
                   spID == package.spID &&
                   spName == package.spName &&
                   spType == package.spType &&
                   spPriority == package.spPriority &&
                   epName == package.epName &&
                   epModel == package.epModel &&
                   epSerialnum == package.epSerialnum &&
                   spReleaseDate == package.spReleaseDate &&
                   spCloseDate == package.spCloseDate &&
                   SPID == package.SPID &&
                   SPName == package.SPName &&
                   SPType == package.SPType &&
                   SPPriority == package.SPPriority &&
                   EPName == package.EPName &&
                   EPModel == package.EPModel &&
                   EPSerialnum == package.EPSerialnum &&
                   SPReleaseDate == package.SPReleaseDate &&
                   SPCloseDate == package.SPCloseDate;
        }

        public override int GetHashCode()
        {
            int hashCode = 1124016226;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(spID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(spName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(spType);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(spPriority);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(epName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(epModel);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(epSerialnum);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(spReleaseDate);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(spCloseDate);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SPID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SPName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SPType);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SPPriority);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EPName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EPModel);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EPSerialnum);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SPReleaseDate);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SPCloseDate);
            return hashCode;
        }

        public override string ToString()
        {
			return SPID +"   "+ SPName;
        }
    }
}
