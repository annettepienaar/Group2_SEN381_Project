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
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();

            EnableDoubleBuffering();

            //Open the login form by default when the form is initialized
            OpenChildForm(new CallInterfaceForm());
        }

        public void EnableDoubleBuffering()
        {
            this.SetStyle(ControlStyles.DoubleBuffer |
               ControlStyles.UserPaint |
               ControlStyles.AllPaintingInWmPaint,
               true);
            this.UpdateStyles();
        }

        #region Menu Bar Controls

        private void btnLoginName_Click(object sender, EventArgs e)
        {
            CMStripLoginName.Show(btnLoginName, 0, btnLoginName.Height);
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LoginForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region Make window movable

        //Code to make the form movable, detects when the mouse button is pressed and move to its location
        private bool mouseDown;
        private Point lastLocation;

        private void pnlheader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pnlheader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pnlheader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion

        #endregion

        #region Child Form Container

        //Code to open Child form where is will close the previous form and add the new one to the childContainer panel
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            
            childForm.BringToFront();
            childForm.Show();

        }

        #endregion

    }
}
