using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_SEN381_Project
{
    abstract class Client
    {
        private string clientID, clientName, clientPhoneNum, clientAddress;
        private List<ServicePackage> servicePackage;

        public abstract void getPhoneNumber();
        public abstract void getAddress();
        public abstract void getServicePackages();


    }
}
