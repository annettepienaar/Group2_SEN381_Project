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
            DataTable dt = access.SearchSP(obj.ServicePackage);

            access.InsertClient(obj.ClientID,obj.ClientName,obj.ClientSurname,obj.BusinessName,obj.ClientPhoneNumber,obj.ClientAddress,dt.Rows[0][0].ToString());
        }

        public static Client Search(string id)
        {
            DataAccess access = new DataAccess();
            DataTable data = new DataTable();
            Client client = null;

            data = access.SearchClient(id);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                client = new Client(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString());
            }
            return client;
        }

        public static List<Client> GetClients()
        {
            DataAccess data = new DataAccess();
            List<Client> lstClient = new List<Client>();

            DataTable tbl = data.GetTable("Client");

            foreach (DataRow row in tbl.Rows)
            {
                lstClient.Add(new Client(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString()));
            }

            return lstClient;
        }

        public static void UpdateClient(string id, string name, string surname, string businessName, string phoneNumber, string address, string sp)
        {
            new DataAccess().UpdateClient(id, name, surname, businessName, phoneNumber, address, sp);
        }
    }
}
