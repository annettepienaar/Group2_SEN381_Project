﻿using Group2_SEN381_Project.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_SEN381_Project.PresentationLayer
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Make window movable

        //Code to make the form movable, detects when the mouse button is pressed and move to its location
        private bool mouseDown;
        private Point lastLocation;

        private void pnlMenuBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pnlMenuBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pnlMenuBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtClientID.Text != "" && txtName.Text != "" && txtSurname.Text != "" && txtPhone.Text != "" && txtAddress.Text != "" && cboxServicePackage.Text != "")
            {
                ClientHandler.Add(new Client(txtClientID.Text, txtName.Text, txtSurname.Text, txtBusinessName.Text, txtPhone.Text, txtAddress.Text, cboxServicePackage.Text));
            }
            else
            {
                MessageBox.Show("Crutial information is missing, Please ensure all crutial information is added");
            }
            
        }

        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CallInterfaceForm.flag--;
        }
    }
}
