using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_SEN381_Project.BusinessLogicLayer
{
    public class SatisfactionEmployee : Employee
    {
        private string address;
        private string empID;
        private string name;
        private string surname;
        private string phoneNum;

        public SatisfactionEmployee(string empID, string name, string surname, string phoneNum, string address)
        {
            this.empID = empID;
            this.name = name;
            this.surname = surname;
            this.phoneNum = phoneNum;
            this.address = address;
        }

        protected override string EmpID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        protected override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        protected override string Surname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        protected override string PhoneNum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        protected override string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override bool Equals(object obj)
        {
            return obj is SatisfactionEmployee employee &&
                   address == employee.address &&
                   empID == employee.empID &&
                   name == employee.name &&
                   surname == employee.surname &&
                   phoneNum == employee.phoneNum;
        }

        public override void getEmpID()
        {
           
        }

        public override int GetHashCode()
        {
            int hashCode = 1608904604;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(address);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(empID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(phoneNum);
            return hashCode;
        }

        public override void getPhoneNum()
        {
            
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
