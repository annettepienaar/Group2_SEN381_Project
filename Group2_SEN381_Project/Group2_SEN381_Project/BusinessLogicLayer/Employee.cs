using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_SEN381_Project.BusinessLogicLayer
{
    public abstract class Employee
    {
        private string address;
        private string empID;
        private string name;
        private string surname;
        private string phoneNum;

        protected abstract string EmpID { get; set; }
        protected abstract string Name { get; set; }
        protected abstract string Surname { get; set; }
        protected abstract string PhoneNum { get; set; }
        protected abstract string Address { get; set; }

        public abstract void getPhoneNum();
        public abstract void getEmpID();
    }
}
