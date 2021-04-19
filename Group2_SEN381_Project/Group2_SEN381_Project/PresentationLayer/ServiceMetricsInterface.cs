using Group2_SEN381_Project.BusinessLogicLayer;
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
	public partial class ServiceMetricsInterface : Form
	{
		//public DataAccess dataAccess = new DataAccess();

		public ServiceMetricsInterface()
		{
			InitializeComponent();
		}

		/*
		public List<ServicePackage> getSP()
		{

		}
		*/

		public void modifySP(string spID)
		{

		}

		public void calcPerformance(ServicePackage spObj)
		{

		}

		private void lblDescripionTitle_Click(object sender, EventArgs e)
		{

		}

		private void btnAddServicePackage_Click(object sender, EventArgs e)
		{
			ServiceCreationInterface serviceCreationInterface = new ServiceCreationInterface();
			serviceCreationInterface.Show();
		}
	}
}
