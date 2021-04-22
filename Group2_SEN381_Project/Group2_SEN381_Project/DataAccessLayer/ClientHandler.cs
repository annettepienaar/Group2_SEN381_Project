using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_SEN381_Project.DataAccessLayer
{
    static class ClientHandler
    {

        public static void Add(Client obj)
        {
            DataAccess access = new DataAccess();
            access.InsertClient(obj.ClientID,obj.ClientName,obj.ClientSurname,obj.BusinessName,obj.ClientPhoneNumber,obj.ClientAddress,obj.ServicePackage);
        }

    }
}
