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

        public abstract string Password { get; }
        public abstract string EmpID { get; set; }
        public abstract string Name { get; set; }
        public abstract string Surname { get; set; }
        public abstract string PhoneNum { get; set; }
        public abstract string Address { get; set; }



        //public override bool Equals(object obj)
        //{
        //    return obj is Employee employee &&
        //           address == employee.address &&
        //           empID == employee.empID &&
        //           name == employee.name &&
        //           surname == employee.surname &&
        //           phoneNum == employee.phoneNum &&
        //           password == employee.password;
        //}

        //public override int GetHashCode()
        //{
        //    int hashCode = 91851540;
        //    hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(address);
        //    hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(empID);
        //    hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
        //    hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(surname);
        //    hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(phoneNum);
        //    hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(password);
        //    return hashCode;
        //}
    }
}
