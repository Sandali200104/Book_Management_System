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
	public partial class FrmHandoverBook : Form
	{
		public FrmHandoverBook()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string? selectedValue = cmbBookType.SelectedItem.ToString();

			DateTime handoverDate = HandoverDate.Value;

			if (selectedValue != null)
			{
				SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

				con.Open();

				string query = "INSERT INTO tblHandoverBooks (BookType, BookName, HandoverDate, CustomerId) VALUES (@BookType, @BookName, @HandoverDate, @CustomerId)";

				SqlCommand cmd = new SqlCommand(query, con);

				cmd.Parameters.AddWithValue("@BookType", selectedValue);
				cmd.Parameters.AddWithValue("@BookName", txtBookName.Text);
				cmd.Parameters.AddWithValue("@HandoverDate", handoverDate);
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

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string? selectedValue = cmbBookType.SelectedItem?.ToString();

			if (selectedValue != null)
			{
				DateTime handoverDate = HandoverDate.Value;

				using (SqlConnection con = new SqlConnection("YourConnectionStringHere"))
				{
					con.Open();

					string query = "UPDATE tblHandoverBooks SET BookType = @BookType, BookName = @BookName, HandoverDate = @HandoverDate, CustomerId = @CustomerId WHERE Id = @HandoverId";

					using (SqlCommand cmd = new SqlCommand(query, con))
					{
						cmd.Parameters.AddWithValue("@BookType", selectedValue);
						cmd.Parameters.AddWithValue("@BookName", txtBookName.Text);
						cmd.Parameters.AddWithValue("@HandoverDate", handoverDate);
						cmd.Parameters.AddWithValue("@CustomerId", txtCustomerId.Text);

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
				}
			}
			else
			{
				MessageBox.Show("Please select a book type!");
			}

		}
	}
}
