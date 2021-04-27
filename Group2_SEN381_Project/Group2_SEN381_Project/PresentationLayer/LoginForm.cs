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
        public LoginForm()
        {
            InitializeComponent();
            EnableDoubleBuffering();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }
        
        public void EnableDoubleBuffering()
        {
            this.SetStyle(ControlStyles.DoubleBuffer |
               ControlStyles.UserPaint |
               ControlStyles.AllPaintingInWmPaint,
               true);
            this.UpdateStyles();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Employee empObject = EmployeeHandler.GetEmployee(txtUsername.Text);

            if (txtPassword.Text.Equals(empObject.Password))
            {
                if (empObject is CallCentreEmployee)
                {
                    //Change to form
                    MessageBox.Show("CallCentreEmployee");
                } else if (empObject is TechnicianEmployee)
                {
                    MessageBox.Show("TechnicianEmployee");
                    //Change to form
                } else if (empObject is SatisfactionEmployee)
                {
                    MessageBox.Show("SatisfactionEmployee");
                    //Change to form
                }
            }
            else
            {
                txtUsername.Text = String.Empty;
                txtPassword.Text = String.Empty;
            }
        }
    }
}
