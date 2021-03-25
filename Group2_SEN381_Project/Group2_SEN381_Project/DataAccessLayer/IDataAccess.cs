using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Group2_SEN381_Project.DataAccessLayer
{
    public interface IDataAccess
    {
        DataTable GetTable(string tblName);
    }
}
