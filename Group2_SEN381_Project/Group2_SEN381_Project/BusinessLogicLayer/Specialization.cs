using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_SEN381_Project.BusinessLogicLayer
{
    class Specialization
    {
        private string specID, specName, specDesc;

        public Specialization(string specID, string specName, string specDesc)
        {
            this.specID = specID;
            this.specName = specName;
            this.specDesc = specDesc;
        }

        public string SpecID
        {
            get { return specID; }
            set { specID = value; }
        }

        public string SpecName 
        {
            get { return specName; }
            set { specName = value; }
        }

        public string SpecDesc
        {
            get { return specDesc; }
            set { specDesc = value; }
        }

        public override bool Equals(object obj)
        {
            return obj is Specialization specialization &&
                   specID == specialization.specID &&
                   specName == specialization.specName &&
                   specDesc == specialization.specDesc;
        }

        public override int GetHashCode()
        {
            int hashCode = -862476137;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(specID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(specName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(specDesc);
            return hashCode;
        }
    }
}
