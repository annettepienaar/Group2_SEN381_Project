using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group2_SEN381_Project.BusinessLogicLayer;

namespace Group2_SEN381_Project
{
    class PersonalClient : Client
    {

        private string pClientID, clientName, clientSurname, clientPhoneNum, clientAddress;
        private List<ServicePackage> servicePackages;

        public PersonalClient( string id, string name, string surname, string num, string address, List<ServicePackage> sp)
        {
            this.pClientID = id;
            this.clientName = name;
            this.clientSurname = surname;
            this.clientPhoneNum = num;
            this.clientAddress = address;
            this.servicePackages = sp;
        }

        public string PClientID
        {
            get { return pClientID; }
            set { pClientID = value; }
        }

        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

        public string ClientSurname
        {
            get { return clientSurname; }
            set { clientSurname = value; }
        }

        public string ClientPhoneNum
        {
            get { return clientPhoneNum; }
            set { clientPhoneNum = value; }
        }

        public string ClientAddress
        {
            get { return clientAddress; }
            set { clientAddress = value; }
        }

        public List<ServicePackage> SP
        {
            get { return servicePackages; }
            set { servicePackages = value; }
        }

        public override bool Equals(object obj)
        {
            return obj is PersonalClient client &&
                   pClientID == client.pClientID &&
                   clientName == client.clientName &&
                   clientSurname == client.clientSurname &&
                   clientPhoneNum == client.clientPhoneNum &&
                   clientAddress == client.clientAddress;
        }

        public override void getAddress()
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            int hashCode = 1478494821;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(pClientID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clientName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clientSurname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clientPhoneNum);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clientAddress);
            return hashCode;
        }

        public override void getPhoneNumber()
        {
            throw new NotImplementedException();
        }

        public override void getServicePackages()
        {
            throw new NotImplementedException();
        }
    }
}
