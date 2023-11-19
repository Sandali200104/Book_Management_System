using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Management_System
{
	public partial class FrmAdminPanel : Form
	{
		public FrmAdminPanel()
		{
			InitializeComponent();
		}

		private void btnCustomer_Click(object sender, EventArgs e)
		{
			new FrmCustomer().Show();
		}

		private void btnBooks_Click(object sender, EventArgs e)
		{
			new FrmBooks().Show();
		}

		private void btnIssuedBooks_Click(object sender, EventArgs e)
		{
			new FrmIssuedBook().Show();
		}

		private void btnBookHandOver_Click(object sender, EventArgs e)
		{
			new FrmHandoverBook().Show();
		}
	}
}
