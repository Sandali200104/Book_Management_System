namespace Book_Management_System
{
	partial class FrmAdminPanel
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnCustomer = new System.Windows.Forms.Button();
			this.btnBooks = new System.Windows.Forms.Button();
			this.btnIssuedBooks = new System.Windows.Forms.Button();
			this.btnBookHandOver = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCustomer
			// 
			this.btnCustomer.Location = new System.Drawing.Point(55, 55);
			this.btnCustomer.Name = "btnCustomer";
			this.btnCustomer.Size = new System.Drawing.Size(75, 23);
			this.btnCustomer.TabIndex = 0;
			this.btnCustomer.Text = "Customer";
			this.btnCustomer.UseVisualStyleBackColor = true;
			this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
			// 
			// btnBooks
			// 
			this.btnBooks.Location = new System.Drawing.Point(168, 55);
			this.btnBooks.Name = "btnBooks";
			this.btnBooks.Size = new System.Drawing.Size(75, 23);
			this.btnBooks.TabIndex = 1;
			this.btnBooks.Text = "Books";
			this.btnBooks.UseVisualStyleBackColor = true;
			this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
			// 
			// btnIssuedBooks
			// 
			this.btnIssuedBooks.Location = new System.Drawing.Point(55, 131);
			this.btnIssuedBooks.Name = "btnIssuedBooks";
			this.btnIssuedBooks.Size = new System.Drawing.Size(96, 23);
			this.btnIssuedBooks.TabIndex = 2;
			this.btnIssuedBooks.Text = "Issued Books";
			this.btnIssuedBooks.UseVisualStyleBackColor = true;
			this.btnIssuedBooks.Click += new System.EventHandler(this.btnIssuedBooks_Click);
			// 
			// btnBookHandOver
			// 
			this.btnBookHandOver.Location = new System.Drawing.Point(168, 131);
			this.btnBookHandOver.Name = "btnBookHandOver";
			this.btnBookHandOver.Size = new System.Drawing.Size(75, 23);
			this.btnBookHandOver.TabIndex = 3;
			this.btnBookHandOver.Text = "Book Hand Over";
			this.btnBookHandOver.UseVisualStyleBackColor = true;
			this.btnBookHandOver.Click += new System.EventHandler(this.btnBookHandOver_Click);
			// 
			// FrmAdminPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnBookHandOver);
			this.Controls.Add(this.btnIssuedBooks);
			this.Controls.Add(this.btnBooks);
			this.Controls.Add(this.btnCustomer);
			this.Name = "FrmAdminPanel";
			this.Text = "FrmAdminPanel";
			this.ResumeLayout(false);

		}

		#endregion

		private Button btnCustomer;
		private Button btnBooks;
		private Button btnIssuedBooks;
		private Button btnBookHandOver;
	}
}