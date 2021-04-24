using System;
using System.Collections.Generic;
using System.Data;
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

        public static Client Search(string id)
        {
            DataAccess access = new DataAccess();
            DataTable data = new DataTable();

            data = access.SearchClient(id);

            //List<Client> clients = new List<Client>();

            DataRow row = data.Rows[0];
            return new Client(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString());

            //foreach (DataRow dr in data.Rows)
            //{
            //    clients.Add(new Client(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString()));
            //}
            //return clients;
        }
    }
}
