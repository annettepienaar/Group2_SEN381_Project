using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group2_SEN381_Project.DataAccessLayer;
using Group2_SEN381_Project.BusinessLogicLayer;

namespace Group2_SEN381_Project.PresentationLayer
{
    public partial class TicketManagementForm : Form
    {
        List<Ticket> unassingedTickets;
        List<TechnicianEmployee> technicians;
        TicketManagementEmployee ticketManagementEmployee;
        public TicketManagementForm(TicketManagementEmployee emp)
        {
            this.ticketManagementEmployee = emp;
            InitializeComponent();
        }

        #region OnForm Loads
        private void TicketManagementForm_Load(object sender, EventArgs e)
        {
            LoadListBox();
            LoadComobBox();
        }
        //Loads unassigned tickets from the database into the listbox
        private void LoadListBox()
        {
            lbUnassignedTickets.Items.Clear();
            unassingedTickets = TicketHandler.GetUnassignedTickets();
            foreach (Ticket ticket in unassingedTickets)
            {
                lbUnassignedTickets.Items.Add(ticket.UnassignedTicketToString());
            }
        }
        //Loads combo box with all technicians
        private void LoadComobBox()
        {
            cbTechnition.Items.Clear();
            technicians = EmployeeHandler.GetTechnicianEmployees();

            foreach (TechnicianEmployee techEmp in technicians)
            {
                cbTechnition.Items.Add(techEmp.ToString());
            }
        }
        #endregion

        //SelectedIndexChanged contains all code for when a selection takes place 
        //and updates any part of the form's information display
        #region SelectedIndexChanged

        //Code for selecting ticket out of list box
        #region ListBoxSelection
        private void lbUnassignedTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbUnassignedTickets.SelectedIndex == -1)
            {

            }
            else
            {
                string selectedItem = lbUnassignedTickets.SelectedItem.ToString();
                int firstSpace = selectedItem.IndexOf(' ');
                string selectedID = selectedItem.Substring(0, firstSpace);
                DisplayTicketInformation(selectedID);
            }
        }
        //Updates information 
        private void DisplayTicketInformation(string id)
        {
            foreach (Ticket ticket in unassingedTickets)
            {
                if (ticket.TicketID == id)
                {
                    txtClientID.Text = ticket.ClientID;
                    txtTicketID.Text = ticket.TicketID;
                    txtTicketState.Text = ticket.TicketState;
                    txtOpenDate.Text = ticket.TicketOpenDate;
                    txtDescription.Text = ticket.TicketDesc;
                    cbTicketLevel.Text = ticket.TicketLevel;
                    cbProblemArea.Text = ticket.ProblemArea;
                }
            }
        }
        #endregion

        //Code for selecting technician out of combo box
        #region ComboBoxSelection
        private void cbTechnition_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTickets.Text = string.Empty;
            txtSpecialization.Text = string.Empty;
            if (cbTechnition.SelectedIndex == -1)
            {

            }
            else
            {
                string selectedItem = cbTechnition.SelectedItem.ToString();
                string selectedID = selectedItem.Substring(0, selectedItem.IndexOf(' '));
                List<Ticket> techOpenTickets = TicketHandler.GetTechOpenTickets(selectedID);

                foreach (TechnicianEmployee tech in technicians)
                {
                    if (tech.EmpID == selectedID)
                    {
                        txtSpecialization.Text = tech.GetSpecializationsNames();
                    }
                }
                foreach (Ticket ticket in techOpenTickets)
                {
                    txtTickets.Text += $"{ticket.UnassignedTicketToString()}, ";
                }
                if (txtTickets.Text != "")
                {
                    txtTickets.Text = txtTickets.Text.Remove(txtTickets.Text.Length - 2);
                }
            }
        }
        #endregion
        #endregion

        #region ButtonClicks
        //Reloads all tickets in the list box
        private void btnReloadTickets_Click(object sender, EventArgs e)
        {

        }
        //Assigns currently selected technician to ticket
        private void btnAssignTicket_Click(object sender, EventArgs e)
        {

        }
        //Updates ticket information to what is in the boxes
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
