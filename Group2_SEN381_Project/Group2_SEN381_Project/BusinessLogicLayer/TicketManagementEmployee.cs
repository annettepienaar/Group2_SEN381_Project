using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_SEN381_Project.BusinessLogicLayer
{
    public class TicketManagementEmployee : Employee
    {
        private string empID;
        private string name;
        private string surname;
        private string address;
        private string phoneNum;
        private string password;

        public TicketManagementEmployee(string empID, string name, string surname, string address, string phoneNum, string password)
        {
            this.empID = empID;
            this.name = name;
            this.surname = surname;
            this.address = address;
            this.phoneNum = phoneNum;
            this.password = password;
        }
        public override string EmpID { get { return empID; } set { empID = value; } }
        public override string Name { get { return name; } set { name = value; } }
        public override string Surname { get { return surname; } set { surname = value; } }
        public override string PhoneNum { get { return phoneNum; } set { phoneNum = value; } }
        public override string Address { get { return address; } set { address = value; } }
        public override string Password { get { return password; } }

        public override bool Equals(object obj)
        {
            return obj is TicketManagementEmployee employee &&
                   Password == employee.Password &&
                   EmpID == employee.EmpID &&
                   Name == employee.Name &&
                   Surname == employee.Surname &&
                   PhoneNum == employee.PhoneNum &&
                   Address == employee.Address &&
                   empID == employee.empID &&
                   name == employee.name &&
                   surname == employee.surname &&
                   address == employee.address &&
                   phoneNum == employee.phoneNum &&
                   password == employee.password &&
                   EmpID == employee.EmpID &&
                   Name == employee.Name &&
                   Surname == employee.Surname &&
                   PhoneNum == employee.PhoneNum &&
                   Address == employee.Address &&
                   Password == employee.Password;
        }

        public override int GetHashCode()
        {
            int hashCode = -2093430428;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EmpID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PhoneNum);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(empID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(address);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(phoneNum);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(password);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EmpID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PhoneNum);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
