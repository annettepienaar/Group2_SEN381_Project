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
        List<Ticket> techTickets;
        public TechnitionInterfaceForm(TechnicianEmployee technicianEmployee)
        {
            this.technicianEmployee = technicianEmployee;
            InitializeComponent();
        }
        //Initiated on form load
        private void TechnitionInterfaceForm_Load(object sender, EventArgs e)
        {
            LoadList();
        }
        //Loads items into the list box
        private void LoadList()
        {
            techTickets = TicketHandler.GetTechOpenTickets(technicianEmployee.EmpID);
            lbAssignedTickets.Items.Clear();
            foreach (Ticket ticket in techTickets)
            {
                lbAssignedTickets.Items.Add(ticket.ToString());
            }
        }
        //code for switching between tickets in ticket list
        private void lbAssignedTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAssignedTickets.SelectedIndex == -1)
            {

            }
            else
            {
                string selectedItem = lbAssignedTickets.SelectedItem.ToString();
                string selectedID = selectedItem.Substring(0, 1);
                UpdateInformation(selectedID);
            }
        }
        //updates the information on the page
        private void UpdateInformation(string id)
        {
            foreach(Ticket item in techTickets)
            {
                if(item.TicketID == id)
                {
                    lblProblemNumber.Text = item.TicketID;
                    lblStatus.Text = item.TicketState;
                    lblUrgencyLevel.Text = item.TicketLevel;
                    txtProblemDescription.Text = item.TicketDesc;
                    UpdateClient(item.ClientID);
                }
            }
        }
        //updates the client information on the form
        private void UpdateClient(string clientID)
        {
            Client problemClient = ClientHandler.Search(clientID);

            lblClientID.Text = problemClient.ClientID;
            lblClientName.Text = problemClient.ClientName;
            lblClientSurname.Text = problemClient.ClientSurname;
            lblClientBusinessName.Text = problemClient.BusinessName;
            lblClientPhone.Text = problemClient.ClientPhoneNumber;
            lblClientAddress.Text = problemClient.ClientPhoneNumber;
        }
        //used to change the state of a ticket to resolved
        private void UpdateTicketState()
        {
            if (lbAssignedTickets.SelectedItem == null)
            {
                MessageBox.Show("Please select a ticket");
            }
            else
            {
                string selectedItem = lbAssignedTickets.SelectedItem.ToString();
                string selectedID = selectedItem.Substring(0, 1);

                foreach (Ticket item in techTickets)
                {
                    if (item.TicketID == selectedID)
                    {
                        item.TicketState = "Resolved";
                        item.TicketCloseDate = DateTime.Now.ToString("yyyy-MM-dd");
                        TicketHandler.UpdateTicket(item);
                    }
                }
            }
           
        }

        private void btnIssueResolved_Click(object sender, EventArgs e)
        {
            string message = "Are you sure the issue has been resolved?";
            string caption = "Issue Resolved?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);

            if (result == DialogResult.Yes)
            {
                UpdateTicketState();
            }
        }

        private void btnReloadTickets_Click(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
