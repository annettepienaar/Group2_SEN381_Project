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

namespace Group2_SEN381_Project
{
    public partial class CallInterfaceForm : Form
    {
        public CallInterfaceForm()
        {
            InitializeComponent();
        }

        #region Clock button

        bool clockRunning = false;
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (clockRunning)
            {
                clockRunning = false;
                btnStartStop.BackColor = Color.FromArgb(34, 220, 76);
                btnStartStop.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 200, 76);
                btnStartStop.Text = "START CALL";

                timer1.Stop();
                lblCallEnd.Text = DateTime.Now.ToString("hh:mm:ss");
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
                lblStartTime.Text = DateTime.Now.ToString("hh:mm:ss");
            }
        }

        #endregion

        bool clientFound = true;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Actual search TODO
            if (clientFound)
            {
                pBoxCustomerFound.Image = Properties.Resources.checkmark_yes_16;
            }
            else
            {
                pBoxCustomerFound.Image = Properties.Resources.checkmark_no_16;
            }

            //For test purposes 
            if (clientFound) { clientFound = false; } else clientFound = true;
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            Form form = new ClientForm();
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
