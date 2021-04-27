using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group2_SEN381_Project.DataAccessLayer;
using System.Data;

namespace Group2_SEN381_Project.BusinessLogicLayer
{
    public class TechnicianEmployee : Employee
    {
        private string empID;
        private string name;
        private string surname;
        private string address;
        private string phoneNum;
        private string password;
        private List<Specialization> specializations; 

        public TechnicianEmployee(string empID, string name, string surname, string address, string phoneNum, string password)
        {
            this.empID = empID;
            this.name = name;
            this.surname = surname;
            this.address = address;
            this.phoneNum = phoneNum;
            this.password = password;
            this.specializations = TicketHandler.GetTechnicianSpecs(this.empID);
        }
       
        public override string EmpID { get { return empID; } set { empID = value; } }
        public override string Name { get { return name; } set { name = value; } }
        public override string Surname { get { return surname; } set { surname = value; } }
        public override string PhoneNum { get { return phoneNum; } set { phoneNum = value; } }
        public override string Address { get { return address; } set { address = value; } }

        public override string Password { get { return password; } }
        public List<Specialization> Specializations { get { return specializations; } }

        public override int GetHashCode()
        {
            int hashCode = -2014792883;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(address);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(empID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(phoneNum);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Specialization>>.Default.GetHashCode(specializations);
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            return obj is TechnicianEmployee employee &&
                   address == employee.address &&
                   empID == employee.empID &&
                   name == employee.name &&
                   surname == employee.surname &&
                   phoneNum == employee.phoneNum &&
                   EqualityComparer<List<Specialization>>.Default.Equals(specializations, employee.specializations);
        }
    }
}
