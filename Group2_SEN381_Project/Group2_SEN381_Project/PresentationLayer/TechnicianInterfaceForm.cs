using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group2_SEN381_Project.BusinessLogicLayer;
using Group2_SEN381_Project.DataAccessLayer;

namespace Group2_SEN381_Project
{
    public partial class TechnitionInterfaceForm : Form
    {
        
        public TechnitionInterfaceForm()
        {
            InitializeComponent();
        }

        public Ticket GetTicket()
        {

            Ticket ticket = null;
            return ticket;
        }

        public List<TechnicianEmployee> GetAvailableTechnician()
        {
            List<TechnicianEmployee> tempTechEmp = new List<TechnicianEmployee>();
            return tempTechEmp;
        }

        public void closeTicket()
        {

        }
    }
}
