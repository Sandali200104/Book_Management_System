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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Book_Management_System
{
	public partial class FrmBooks : Form
	{
		public FrmBooks()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string selectedValue = cmbBookType.SelectedItem?.ToString(); // Use null conditional operator

			if (selectedValue != null)
			{
				SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

				con.Open();

				string query = "UPDATE tblBooks SET BookName = @BookName WHERE BookType = @BookType";

				SqlCommand cmd = new SqlCommand(query, con);

				cmd.Parameters.AddWithValue("@BookName", txtBookName.Text);
				cmd.Parameters.AddWithValue("@BookType", selectedValue);

				int rowsAffected = cmd.ExecuteNonQuery();

				if (rowsAffected > 0)
				{
					MessageBox.Show("Data updated successfully!");
				}
				else
				{
					MessageBox.Show("Failed to update data.");
				}
			}
			else
			{
				MessageBox.Show("Please select a book type!");
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			int searchId;
			if (int.TryParse(txtId.Text, out searchId))
			{
				SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
				con.Open();
				string query = "Select BookName,BookType From tblBooks Where Id = @Id";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@Id", searchId);
				SqlDataReader sr = cmd.ExecuteReader();
				if (sr.Read())
				{
					txtBookName.Text = sr["BookName"].ToString();
					string? bookType = sr["BookType"].ToString();
					cmbBookType.Items.Clear();
					cmbBookType.Items.Add(bookType);
					cmbBookType.SelectedIndex = 0;
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
			if (int.TryParse(txtId.Text, out deleteId))
			{
				SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
				con.Open();
				string query = "Delete From tblBooks Where Id = @Id";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@Id", deleteId);
				int rowsAffected = cmd.ExecuteNonQuery();
				if (rowsAffected > 0)
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
			txtBookName.Text = "";
			cmbBookType.Items.Clear();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string? selectedValue = cmbBookType.SelectedItem.ToString();

			if (selectedValue != null)
			{
				SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

				con.Open();

				string query = "UPDATE tblBooks " +
							   "SET BookName = @BookName, BookType = @BookType" +
							   "WHERE Id = @BookID";

				SqlCommand cmd = new SqlCommand(query, con);

				cmd.Parameters.AddWithValue("@BookName", txtBookName.Text);
				cmd.Parameters.AddWithValue("@BookType", selectedValue);
				cmd.Parameters.AddWithValue("@BookID", txtId.Text);

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
}
