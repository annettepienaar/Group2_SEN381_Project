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
        TechnicianEmployee technicianEmployee;
        public TechnitionInterfaceForm(TechnicianEmployee technicianEmployee)
        {
            this.technicianEmployee = technicianEmployee;
            InitializeComponent();
        }

        private void TechnitionInterfaceForm_Load(object sender, EventArgs e)
        {
            List<Ticket> techTickets = TicketHandler.GetTechOpenTickets(technicianEmployee.EmpID);

            foreach(Ticket ticket in techTickets)
            {
                
                lbAssignedTickets.Items.Add(ticket.ToString());
            }
        }

        //public Ticket GetTicket()
        //{

        //    Ticket ticket = null;
        //    return ticket;
        //}

        //public List<TechnicianEmployee> GetAvailableTechnician()
        //{
        //    List<TechnicianEmployee> tempTechEmp = new List<TechnicianEmployee>();
        //    return tempTechEmp;
        //}

        //public void closeTicket()
        //{

        //}
    }
}
