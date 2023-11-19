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
	public partial class FrmIssuedBook : Form
	{
		public FrmIssuedBook()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string? selectedValue = cmbBookType.SelectedItem.ToString();

			DateTime issuedDate = IssueddateTime.Value;

			if (selectedValue != null)
			{
				SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

				con.Open();

				string query = "INSERT INTO tblIssuedBooks (BookType, BookName, IssuedDate, CustomerId) VALUES (@BookType, @BookName, @IssuedDate, @CustomerId)";

				SqlCommand cmd = new SqlCommand(query, con);

				cmd.Parameters.AddWithValue("@BookType", selectedValue);
				cmd.Parameters.AddWithValue("@BookName", txtBookName.Text);
				cmd.Parameters.AddWithValue("@IssuedDate", issuedDate);
				cmd.Parameters.AddWithValue("@CustomerId", txtCustomerId.Text);

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
			else
			{
				MessageBox.Show("Please select book type!");
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int deleteId;
			if (int.TryParse(txtId.Text, out deleteId))
			{
				SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
				con.Open();
				string query = "Delete From tblIssuedBooks  Where Id = @Id";
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

		private void btnSearch_Click(object sender, EventArgs e)
		{
			int searchId;
			if (int.TryParse(txtId.Text, out searchId))
			{
				SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
				con.Open();
				string query = "Select BookType, BookName, IssuedDate,CustomerId From tblIssuedBooks Where Id = @Id";
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
					string? issuedDate = sr["IssuedDate"].ToString();
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

		private void btnUpdate_Click(object sender, EventArgs e)
		{

		}
	}
}
