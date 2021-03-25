using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_SEN381_Project.BusinessLogicLayer
{
    public class TechnicianEmployee : Employee
    {
        private string address;
        private string empID;
        private string name;
        private string surname;
        private string phoneNum;
        private List<Specialization> specializations; 
        public TechnicianEmployee(string address, string empID, string name, string surname, string phoneNum)
        {
            this.address = address;
            this.empID = empID;
            this.name = name;
            this.surname = surname;
            this.phoneNum = phoneNum;
        }
        protected override string EmpID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        protected override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        protected override string Surname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        protected override string PhoneNum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        protected override string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void getEmpID()
        {
            throw new NotImplementedException();
        }

        public override void getPhoneNum()
        {
            throw new NotImplementedException();
        }

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
