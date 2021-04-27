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
        ChildFormHandler childFormHandler;
        public ParentForm()
        {
            InitializeComponent(); 

            EnableDoubleBuffering();

            childFormHandler = new ChildFormHandler(pnlChildForm);
            //Open the login form by default when the form is initialized
            childFormHandler.OpenChildForm(new LoginForm(childFormHandler));
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
            childFormHandler.OpenChildForm(new LoginForm(childFormHandler));
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

        

        #endregion

    }
}
