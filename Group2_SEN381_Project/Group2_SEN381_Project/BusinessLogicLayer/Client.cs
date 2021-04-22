using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group2_SEN381_Project.BusinessLogicLayer;

namespace Group2_SEN381_Project
{
    class Client
    {
        private string clientID, clientName, clientSurname, businessName, clientPhoneNum, clientAddress, servicePackage;

        public Client(string id, string name, string surname, string businessName, string number, string address, string sp)
        {
            this.clientID = id;
            this.clientName = name;
            this.clientSurname = surname;
            this.businessName = businessName;
            this.clientPhoneNum = number;
            this.clientAddress = address;
            this.servicePackage = sp;
        }

        public string ClientID
        {
            get { return clientID; }
            set { clientID = value; }
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

        public string BusinessName
        {
            get { return businessName; }
            set { businessName = value; }
        }

        public string ClientPhoneNumber
        {
            get { return clientPhoneNum; }
            set { clientPhoneNum = value; }
        }

        public string ClientAddress
        {
            get { return clientAddress; }
            set { clientAddress = value; }
        }

        public string ServicePackage
        {
            get { return servicePackage; }
            set { servicePackage = value; }
        }

        public override bool Equals(object obj)
        {
            return obj is Client client &&
                   clientID == client.clientID &&
                   clientName == client.clientName &&
                   clientSurname == client.clientSurname &&
                   businessName == client.businessName &&
                   clientPhoneNum == client.clientPhoneNum &&
                   clientAddress == client.clientAddress &&
                   servicePackage == client.servicePackage &&
                   ClientID == client.ClientID &&
                   ClientName == client.ClientName &&
                   ClientSurname == client.ClientSurname &&
                   BusinessName == client.BusinessName &&
                   ClientPhoneNumber == client.ClientPhoneNumber &&
                   ClientAddress == client.ClientAddress &&
                   ServicePackage == client.ServicePackage;
        }

        public override int GetHashCode()
        {
            int hashCode = 1387460091;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clientID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clientName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clientSurname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(businessName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clientPhoneNum);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clientAddress);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(servicePackage);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClientID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClientName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClientSurname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BusinessName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClientPhoneNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClientAddress);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ServicePackage);
            return hashCode;
        }
    }
}
