using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_SEN381_Project.PresentationLayer
{
    public class ChildFormHandler
    {
        private Panel pnlChildForm;
        public ChildFormHandler(Panel pnlChildForm)
        {
            this.pnlChildForm = pnlChildForm;
        }

        //Code to open Child form where is will close the previous form and add the new one to the childContainer panel
        private Form activeForm = null;
        public void OpenChildForm(Form childForm)
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
    }
}
