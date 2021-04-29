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
    public partial class LoginForm : Form
    {
        ChildFormHandler childFormHandler;
        public LoginForm(ChildFormHandler childFormHandler)
        {
            InitializeComponent();
            this.childFormHandler = childFormHandler;
        }

        #region Form Loading Changes

        private void LoginForm_Load(object sender, EventArgs e)
        {
            EnableDoubleBuffering();
            //Hide the incorrect username or password on start
            lblIncorrect.Visible = false;
        }
        //Enabling double buffering helps to make the screen less flickery
        public void EnableDoubleBuffering()
        {
            this.SetStyle(ControlStyles.DoubleBuffer |
               ControlStyles.UserPaint |
               ControlStyles.AllPaintingInWmPaint,
               true);
            this.UpdateStyles();
        }

        #endregion

        #region Login Function

        //Execute the login function for a enter key press and clicking the button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Login();
            }
        }

        private void Login()
        {
            //Search for they employees who match the text in the username textbox
            Employee empObject = EmployeeHandler.GetEmployee(txtUsername.Text.Trim());

            //Hide the incorrect username or password on start
            lblIncorrect.Visible = false;

            //If the object found and its password match then open the form and change userDisplay
            if (empObject != null && txtPassword.Text.Trim().Equals(empObject.Password))
            {
                if (empObject is CallCentreEmployee)
                {
                    //Change to form
                    childFormHandler.OpenChildForm(new CallInterfaceForm((CallCentreEmployee)empObject));
                    childFormHandler.ChangeUserDisplay(empObject.Name + " " + empObject.Surname);
                }
                else if (empObject is TechnicianEmployee)
                {
                    childFormHandler.OpenChildForm(new TechnitionInterfaceForm((TechnicianEmployee)empObject));
                    childFormHandler.ChangeUserDisplay(empObject.Name + " " + empObject.Surname);
                    //Change to form
                }
                else if (empObject is SatisfactionEmployee)
                {
                    childFormHandler.OpenChildForm(new ServiceMetricsForm((SatisfactionEmployee)empObject));
                    childFormHandler.ChangeUserDisplay(empObject.Name + " " + empObject.Surname);
                    //Change to form
                }
            }
            else
            {
                //Clear the incorrect password if the username and password didnt match
                txtPassword.Text = null;
                //Show that either the username or the password where incorrect
                lblIncorrect.Visible = true;
            }
        }

        #endregion

        private void btnClearUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Text = null;
        }

        private void btnClearPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = null;
        }
    }
}
