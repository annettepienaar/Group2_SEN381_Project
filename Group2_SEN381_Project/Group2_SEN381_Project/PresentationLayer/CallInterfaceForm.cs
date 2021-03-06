using Group2_SEN381_Project.DataAccessLayer;
using Group2_SEN381_Project.PresentationLayer;
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

namespace Group2_SEN381_Project
{
    public partial class CallInterfaceForm : Form
    {
        BindingSource sourceC, sourceT;

        CallCentreEmployee callCentreEmployee;

        public CallInterfaceForm(CallCentreEmployee callCentreEmployee)
        {
            InitializeComponent();

            this.callCentreEmployee = callCentreEmployee;

            sourceC = new BindingSource();
            sourceT = new BindingSource();
        }

        #region Clock button

        bool clockRunning = false;
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (clockRunning)
            {
                timer1.Stop();
                
                DialogResult dialog = MessageBox.Show("End Call and Submit Ticket?", "End Call", MessageBoxButtons.YesNoCancel);
                switch (dialog)
                {
                    case DialogResult.Cancel:
                        btnClear.Enabled = false;

                        timer1.Start();
                        break;
                    case DialogResult.Yes:
                        clockRunning = false;
                        btnStartStop.BackColor = Color.FromArgb(34, 220, 76);
                        btnStartStop.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 200, 76);
                        btnStartStop.Text = "START CALL";
                        lblCallEnd.Text = DateTime.Now.ToString("HH:mm:ss");

                        btnClear.Enabled = true;

                        string startTime = DateTime.Now.ToString("yyyy-MM-dd") + " " + lblStartTime.Text;
                        string endTime = DateTime.Now.ToString("yyyy-MM-dd") + " " + lblCallEnd.Text;
                        CallHandler.Call(startTime, endTime, txtClientID.Text, callCentreEmployee.EmpID);

                        string openDate = DateTime.Now.ToString("yyyy-MM-dd");
                        TicketHandler.TicketCreation(rtxtProblemDesc.Text, cboxUrgencyLevel.SelectedItem.ToString(), "Unresolved", openDate, "", cboxProblemArea.SelectedItem.ToString(), txtClientID.Text, callCentreEmployee.EmpID);
                        break;
                    case DialogResult.No:
                        clockRunning = false;
                        btnStartStop.BackColor = Color.FromArgb(34, 220, 76);
                        btnStartStop.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 200, 76);
                        btnStartStop.Text = "START CALL";
                        lblCallEnd.Text = DateTime.Now.ToString("HH:mm:ss");

                        btnClear.Enabled = true;

                        //Just end Call, don't send data to DB
                        break;
                    default:
                        break;
                }
            }
            else
            {
                clockRunning = true;
                btnStartStop.BackColor = Color.FromArgb(255, 128, 128);
                btnStartStop.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 128, 128);
                btnStartStop.Text = "STOP CALL";

                counter = 0;
                timer1.Start();
                lblCallEnd.Text = null;
                lblStartTime.Text = DateTime.Now.ToString("HH:mm:ss");

                btnClear.Enabled = false;
            }
        }

        #endregion

        //bool clientFound = true;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool clientFound = false;
            Client clients = ClientHandler.Search(txtClientID.Text);

            if (clients != null)
            {
                clientFound = true;
            }
            else
            {
                clientFound = false;
            }


            //Actual search TODO
            if (clientFound)
            {
                pBoxCustomerFound.Image = Properties.Resources.checkmark_yes_16;

                sourceC.DataSource = CallHandler.GetCall(txtClientID.Text);
                sourceT.DataSource = CallHandler.GetTickets(txtClientID.Text);

                dgvAllCalls.DataSource = sourceC;
                dgvAllTickets.DataSource = sourceT;
            }
            else
            {
                pBoxCustomerFound.Image = Properties.Resources.checkmarkRed_no_16;
            }

            //For test purposes 
            //if (clientFound) { clientFound = false; } else clientFound = true;
        }

        public static int flag = 0;
        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            Form form = new ClientForm(txtClientID);
            flag++;
            form.Show();

            //Disables button after click
            btnCreateClient.Enabled = false;
        }


        #region Timer
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            int minutes = (int)counter / 60;
            int seconds = (int)counter % 60;

            //Formats time counter :)
            lblDuration.Text = $"{(minutes.ToString().Length < 2 ? "0" + minutes.ToString(): minutes.ToString())}:{(seconds.ToString().Length < 2 ? "0" + seconds.ToString(): seconds.ToString())}";
        }


        #endregion

        private void CallInterfaceForm_MouseMove(object sender, MouseEventArgs e)
        {
            //Enables Create Client button
            if (flag <= 0)
            {
                btnCreateClient.Enabled = true;
            }
        }

        //private void CreateTicket()
        //{
        //    string technicianId = "", ticketId = "", ticketState = "Unresolved", closeDate = "";
        //    string currentDate = DateTime.Now.ToString("dd/mm/yyy");
        //    Ticket ticket = new Ticket(ticketId, rtxtProblemDesc.Text, cboxUrgencyLevel.Text, ticketState, currentDate, closeDate, cboxProblemArea.SelectedText, txtClientID.Text, technicianId, callInterfaceID);

        //    TicketHandler.Add(ticket);
        //}

        private void CallInterfaceForm_Load(object sender, EventArgs e)
        {
            //txtClientID.Text = ClientForm.clientID;
        }

        #region Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClientID.Text = String.Empty;
            cboxUrgencyLevel.SelectedItem = null;
            cboxProblemArea.SelectedItem = null;
            rtxtProblemDesc.Text = String.Empty;
            dgvAllCalls.DataSource = null;
            dgvAllTickets.DataSource = null;
            cboxProblemArea.Text = null;
            cboxUrgencyLevel.Text = null;
            lblStartTime.Text = String.Empty;
            lblCallEnd.Text = String.Empty;
            lblDuration.Text = String.Empty;
            pBoxCustomerFound.Image = Properties.Resources.circle_16;
        }

        private void dgvAllCalls_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        //DateTime callStart;
        //DateTime callEnd;

        //public void addClient()
        //{

        //}

        //public void modifyClient()
        //{

        //}

        //public void createTicket()
        //{

        //}

    }
}
