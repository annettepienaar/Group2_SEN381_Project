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

        #region OnFormLoads
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

                foreach (Ticket ticket in unassingedTickets)
                {
                    if (ticket.TicketID == selectedID)
                    {
                        DisplayTicketInformation(ticket);
                        DisplayClientInfromation(ticket);
                        break;
                    }
                }
                
            }
        }
        //Updates information 
        private void DisplayTicketInformation(Ticket ticket)
        {
            txtClientID.Text = ticket.ClientID;
            txtTicketID.Text = ticket.TicketID;
            txtTicketState.Text = ticket.TicketState;
            txtOpenDate.Text = ticket.TicketOpenDate;
            txtDescription.Text = ticket.TicketDesc;
            cbTicketLevel.Text = ticket.TicketLevel;
            cbProblemArea.Text = ticket.ProblemArea;
        }

        private void DisplayClientInfromation(Ticket ticket)
        {
            Client client = ClientHandler.Search(ticket.ClientID);

            txtClientName.Text = client.ClientName + " " + client.ClientSurname;
            txtClientPhone.Text = client.ClientPhoneNumber;
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
            LoadListBox();
            clearLabels();
        }

        private void clearLabels()
        {
            txtTicketID.Text = String.Empty;
            txtTicketState.Text = String.Empty;
            cbTicketLevel.SelectedItem = null;
            cbProblemArea.SelectedItem = null;
            txtTicketID.Text = String.Empty;
            txtOpenDate.Text = String.Empty;
            txtClientID.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtClientName.Text = String.Empty;
            txtClientPhone.Text = String.Empty;
        }

        //Assigns currently selected technician to ticket
        private void btnAssignTicket_Click(object sender, EventArgs e)
        {
            if (lbUnassignedTickets.SelectedIndex == -1 && cbTechnition.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a ticket to assign and technician to assign");
            }
            else
            {
                string txtSpecs = txtSpecialization.Text;
                string[] indSpecs = txtSpecs.Split(',');
                //Ensuring each entry has no leading or trailing blanks
                for (int i = 0; i < indSpecs.Length; i++)
                {
                    indSpecs[i] = indSpecs[i].Trim();
                }

                if (indSpecs.Contains(cbProblemArea.Text))
                {
                    string selectedItem = cbTechnition.Text;
                    int firstSpace = selectedItem.IndexOf(' ');
                    string selectedID = selectedItem.Substring(0, firstSpace);
                    foreach (Ticket item in unassingedTickets)
                    {
                        if (item.TicketID == txtTicketID.Text)
                        {
                            item.TechnitionID = selectedID;
                            TicketHandler.AssignTechnicians(item);
                        }
                    }

                }


            }
        }
        //Updates ticket information to what is in the boxes
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to update ticket information?";
            string caption = "Update Ticket Info?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);

            if (result == DialogResult.Yes)
            {
                foreach (Ticket item in unassingedTickets)
                {
                    if (item.TicketID == txtTicketID.Text)
                    {
                        item.TicketLevel = cbTicketLevel.SelectedItem.ToString();
                        item.ProblemArea = cbProblemArea.SelectedItem.ToString();
                        TicketHandler.UpdateCreatedTicket(item);
                        LoadListBox();
                    }
                }
            }
        }

        bool callStarted = false;
        private void btnStartStop_Click(object sender, EventArgs e)
        {

            if (callStarted)
            {
                DialogResult dialog = MessageBox.Show("End Call?", "End Call", MessageBoxButtons.OKCancel);
                switch (dialog)
                {
                    case DialogResult.OK:
                        btnStartStop.BackColor = Color.FromArgb(34, 220, 76);
                        btnStartStop.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 200, 76);
                        btnStartStop.Text = "START CALL";

                        callStarted = false;
                        break;
                    case DialogResult.Cancel:
                        //Nothing happens
                        break;
                    default:
                        break;
                }
            }
            else
            {
                btnStartStop.BackColor = Color.FromArgb(255, 128, 128);
                btnStartStop.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 128, 128);
                btnStartStop.Text = "STOP CALL";

                callStarted = true;
            }
        }

        #endregion



        }
}
