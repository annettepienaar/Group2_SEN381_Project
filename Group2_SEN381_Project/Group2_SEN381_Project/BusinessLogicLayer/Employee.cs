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
        private string password;

        public abstract string EmpID { get; set; }
        public abstract string Name { get; set; }
        public abstract string Surname { get; set; }
        public abstract string PhoneNum { get; set; }
        public abstract string Address { get; set; }
        public abstract string Password { get; set; }

    }
}
