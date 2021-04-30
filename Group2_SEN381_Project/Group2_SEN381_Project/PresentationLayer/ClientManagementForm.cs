using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group2_SEN381_Project.BusinessLogicLayer;
using Group2_SEN381_Project.DataAccessLayer;

namespace Group2_SEN381_Project.PresentationLayer
{
    public partial class ClientManagementForm : Form
    {
        List<Client> lstClients;
        public ClientManagementForm(ClientManagementEmployee employee)
        {
            InitializeComponent();
        }

        #region Form on Load Functions

        private void ClientManagementForm_Load(object sender, EventArgs e)
        {
            //Gets the client list and updates the relevant elements
            UpdateList();
            //A method which fills the combo box options which existing ServicePacakges
            PopulateServicePackageCBox();
        }

        

        private void PopulateServicePackageCBox()
        {
            List<ServicePackage> lstServicePackage = ServicePackageHandler.GetAllSP();

            foreach (ServicePackage sp in lstServicePackage)
            {
                cboxClientServicePackage.Items.Add(sp.SPID);
            }
        }
        #endregion

        #region Buttton Functions

        private void btnReloadTickets_Click(object sender, EventArgs e)
        {
            //A method which gets a list of clients 
            GetClientList();
            //A method which populates the left panels list box with the lstClient entries 
            PopulateList();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClientHandler.UpdateClient(lblClientID.Text, txtClientName.Text, txtClientSurname.Text, txtClientBusinessName.Text, txtClientPhone.Text, txtClientAddress.Text, cboxClientServicePackage.Text);
            UpdateList();
        }

        #endregion

        #region List functions
        private void UpdateList()
        {
            //A method to update the list box
            GetClientList();
            PopulateList();
        }

        //A method which gets a list of clients 
        private void GetClientList()
        {
            lstClients = ClientHandler.GetClients();
        }

        //A method which populates the left panels list box with the lstClient entries 
        private void PopulateList()
        {
            //Clear the list box so stray data doesnt end up in it
            lbClients.Items.Clear();
            //Run through the list adding each one of its entries to the list box
            foreach (Client client in lstClients)
            {
                lbClients.Items.Add(client.ToString());
            }
        }

        private void lbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check to make sure a item is being selected then use the clientDisplay method to change the GUI elements
            if (lbClients.SelectedIndex != -1)
            {
                ClientDisplay(lbClients.SelectedItem.ToString().Substring(0, 9));
            }
        }
        #endregion

        #region Client Display

        private void ClientDisplay(string clientID)
        {
            ChangeTxtBoxes(clientID);
            ChangeTicketDView(clientID);
        }

        private void ChangeTxtBoxes(string clientID)
        {
            foreach (Client client in lstClients)
            {
                if (client.ClientID == clientID)
                {
                    lblClientID.Text = client.ClientID;
                    txtClientName.Text = client.ClientName;
                    txtClientSurname.Text = client.ClientSurname;
                    txtClientBusinessName.Text = client.BusinessName;
                    txtClientPhone.Text = client.ClientPhoneNumber;
                    txtClientAddress.Text = client.ClientAddress;
                    cboxClientServicePackage.Text = client.ServicePackage;
                    return;
                }
            }
        }

        private void ChangeTicketDView(string clientID)
        {
            dgvClientTickets.DataSource = TicketHandler.GetClientTicketTable(clientID);
        }

        #endregion
    }
}
