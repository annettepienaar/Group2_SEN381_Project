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
                e.SuppressKeyPress = true;
            }
        }

        private void Login()
        {
            //Hide the incorrect username or password on start
            lblIncorrect.Visible = false;

            //Storing the textboxes input into variables for later use
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            //Search for they employees who match the text in the username textbox
            Employee empObject = EmployeeHandler.GetEmployee(username);

            //If the object found and its password match then open the form and change userDisplay
            if (empObject != null && password.Equals(empObject.Password))
            {
                //Var used to change the top panels displayed text
                string userNameAndSurname = empObject.Name + " " + empObject.Surname;

                //Checks the type of employee recieved then opens the correct form whilst changing the displayed employee
                if (empObject is CallCentreEmployee)
                {
                    childFormHandler.OpenChildForm(new CallInterfaceForm((CallCentreEmployee)empObject));
                    childFormHandler.ChangeUserDisplay(userNameAndSurname);
                }
                else if (empObject is TechnicianEmployee)
                {
                    childFormHandler.OpenChildForm(new TechnitionInterfaceForm((TechnicianEmployee)empObject));
                    childFormHandler.ChangeUserDisplay(userNameAndSurname);
                }
                else if (empObject is SatisfactionEmployee)
                {
                    childFormHandler.OpenChildForm(new ServiceMetricsForm((SatisfactionEmployee)empObject));
                    childFormHandler.ChangeUserDisplay(userNameAndSurname);
                }else if (empObject is ClientManagementEmployee)
                {
                    childFormHandler.OpenChildForm(new ClientManagementForm((ClientManagementEmployee)empObject));
                    childFormHandler.ChangeUserDisplay(userNameAndSurname);
                }
                else if (empObject is TicketManagementEmployee)
                {
                    childFormHandler.OpenChildForm(new TicketManagementForm((TicketManagementEmployee)empObject));
                    childFormHandler.ChangeUserDisplay(userNameAndSurname);
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

        #region Button Clear Code
        private void btnClearUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Text = null;
        }

        private void btnClearPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = null;
        }
        #endregion
    }
}
