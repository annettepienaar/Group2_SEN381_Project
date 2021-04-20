using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group2_SEN381_Project.BusinessLogicLayer;

namespace Group2_SEN381_Project
{
    class BusinessClient : Client
    {

        private string bClientID, businessName, contactInfo, clientPhoneNum, businessAddress;
        private List<ServicePackage> servicePackages;

        public BusinessClient(string id, string name, string contact, string phone, string address, List<ServicePackage> sp)
        {
            this.bClientID = id;
            this.businessName = name;
            this.contactInfo = contact;
            this.clientPhoneNum = phone;
            this.businessAddress = address;
            this.servicePackages = sp;
        }

        public string BClientID
        {
            get { return bClientID; }
            set { bClientID = value; }
        }

        public string BusinessName
        {
            get { return businessName; }
            set { businessName = value; }
        }

        public string ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }

        public string ClientPhoneNum
        {
            get { return clientPhoneNum; }
            set { clientPhoneNum = value; }
        }

        public string BusinessAddress
        {
            get { return businessAddress; }
            set { businessAddress = value; }
        }

        public List<ServicePackage> SP
        {
            get { return servicePackages; }
            set { servicePackages = value; }
        }

        public override bool Equals(object obj)
        {
            return obj is BusinessClient client &&
                   bClientID == client.bClientID &&
                   businessName == client.businessName &&
                   contactInfo == client.contactInfo &&
                   clientPhoneNum == client.clientPhoneNum &&
                   businessAddress == client.businessAddress;
        }

        public override void getAddress()
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            int hashCode = 272528505;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(bClientID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(businessName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(contactInfo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clientPhoneNum);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(businessAddress);
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
