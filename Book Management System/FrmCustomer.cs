using Microsoft.Data.SqlClient;
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
	public partial class FrmCustomer : Form
	{
		public FrmCustomer()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string selectedGender = "";
			if (rbMale.Checked)
				selectedGender = "Male";
			if (rbFemale.Checked)
				selectedGender = "Female";

			SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");		

			con.Open();

			string query = "INSERT INTO tblCustomers (FirstName, LastName, Gender, Address) " +
							"VALUES (@FirstName, @LastName, @Gender, @Address)";

			SqlCommand cmd = new SqlCommand(query, con);
			
			cmd.Parameters.AddWithValue("@FirstName", txtFName.Text);
			cmd.Parameters.AddWithValue("@LastName", txtLName.Text);
			cmd.Parameters.AddWithValue("@Gender", selectedGender);
			cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

			int rowsAffected = cmd.ExecuteNonQuery();

			if (rowsAffected > 0)
			{
				MessageBox.Show("Data saved successfully!");
			}
			else
			{
				MessageBox.Show("Failed to save data.");
			}		
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			int searchId;
			if(int.TryParse(txtId.Text, out searchId))
			{
				SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
				con.Open();
				string query = "Select FirstName,LastName,Gender,Address From tblCustomers Where Id = @Id";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@Id", searchId);
				SqlDataReader sr = cmd.ExecuteReader();
				if (sr.Read())
				{
					txtFName.Text = sr["FirstName"].ToString();
					txtLName.Text = sr["LastName"].ToString();
					string gender = sr["Gender"]?.ToString() ?? null;
					if(gender == "Male")
					{
						rbMale.Checked = true;
					}
					if (gender == "Female")
					{
						rbFemale.Checked = true;
					}
					txtAddress.Text = sr["Address"].ToString();
				}
				else
				{
					MessageBox.Show("No data found for the given ID.");
				}
			}
			else
			{
				MessageBox.Show("Please enter a valid numeric ID.");
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int deleteId;
			if (int.TryParse(txtId.Text,out deleteId))
			{
				SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
				con.Open();
				string query = "Delete From tblCustomers Where Id = @Id";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@Id", deleteId);
				int rowsAffected = cmd.ExecuteNonQuery();
				if(rowsAffected > 0)
				{
					MessageBox.Show("Data deleted successfully!");
				}
				else
				{
					MessageBox.Show("No data found for the given ID.");
				}
			}
			else
			{
				MessageBox.Show("Please enter a valid numeric ID for deletion.");
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtId.Text = "";
			txtFName.Text = "";
			txtLName.Text = "";
			rbMale.Checked = false;
			rbFemale.Checked = false;
			txtAddress.Text = "";
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string selectedGender = "";
			if (rbMale.Checked)
				selectedGender = "Male";
			if (rbFemale.Checked)
				selectedGender = "Female";

			SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

			con.Open();

			string query = "UPDATE tblCustomers " +
						   "SET FirstName = @FirstName, LastName = @LastName, Gender = @Gender, Address = @Address " +
						   "WHERE Id = @CustomerID"; 

			SqlCommand cmd = new SqlCommand(query, con);

			cmd.Parameters.AddWithValue("@FirstName", txtFName.Text);
			cmd.Parameters.AddWithValue("@LastName", txtLName.Text);
			cmd.Parameters.AddWithValue("@Gender", selectedGender);
			cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
			cmd.Parameters.AddWithValue("@CustomerID", txtId.Text); 

			int rowsAffected = cmd.ExecuteNonQuery();

			if (rowsAffected > 0)
			{
				MessageBox.Show("Data updated successfully!");
			}
			else
			{
				MessageBox.Show("Failed to update data.");
			}

			con.Close();
		}
	}
}
