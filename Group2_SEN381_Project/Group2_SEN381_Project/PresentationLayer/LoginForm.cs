﻿using System;
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
            EnableDoubleBuffering();
            this.childFormHandler = childFormHandler;
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

            if (empObject != null)
            {
                if (txtPassword.Text.Equals(empObject.Password))
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
                    txtUsername.Text = String.Empty;
                    txtPassword.Text = String.Empty;
                }
            }
        }
    }
}
