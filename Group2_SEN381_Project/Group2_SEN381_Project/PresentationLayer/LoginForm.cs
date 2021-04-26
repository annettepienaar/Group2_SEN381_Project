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

namespace Group2_SEN381_Project.PresentationLayer
{
    public partial class LoginForm : Form
    {
        EmployeeHandler employeeHandler;

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
            employeeHandler = new EmployeeHandler();

            char employeeType = employeeHandler.EmployeeLogin(txtUsername.Text, txtPassword.Text);

            if (employeeType.Equals('C'))
            {
                //Open CallInterfaceForm
            } else if (employeeType.Equals("T"))
            {
                //Open Technition Form
            } else if (employeeType.Equals("S"))
            {
                //Open Satisfaction Form
            } else
            {
                MessageBox.Show("Employee Unknown");
                txtUsername.Text = String.Empty;
                txtPassword.Text = String.Empty;
            }
        }
    }
}
