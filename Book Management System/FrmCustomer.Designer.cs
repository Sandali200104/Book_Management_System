namespace Book_Management_System
{
	partial class FrmCustomer
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtLName = new System.Windows.Forms.TextBox();
			this.txtFName = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.rbGender = new System.Windows.Forms.Label();
			this.rbMale = new System.Windows.Forms.RadioButton();
			this.rbFemale = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 15);
			this.label2.TabIndex = 9;
			this.label2.Text = "Last Name";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtLName
			// 
			this.txtLName.Location = new System.Drawing.Point(119, 55);
			this.txtLName.Name = "txtLName";
			this.txtLName.Size = new System.Drawing.Size(100, 23);
			this.txtLName.TabIndex = 7;
			// 
			// txtFName
			// 
			this.txtFName.Location = new System.Drawing.Point(119, 17);
			this.txtFName.Name = "txtFName";
			this.txtFName.Size = new System.Drawing.Size(100, 23);
			this.txtFName.TabIndex = 6;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(4, 205);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 26);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(108, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 15);
			this.label3.TabIndex = 10;
			this.label3.Text = "Customer";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 15);
			this.label1.TabIndex = 11;
			this.label1.Text = "First Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// rbGender
			// 
			this.rbGender.AutoSize = true;
			this.rbGender.Location = new System.Drawing.Point(3, 101);
			this.rbGender.Name = "rbGender";
			this.rbGender.Size = new System.Drawing.Size(45, 15);
			this.rbGender.TabIndex = 12;
			this.rbGender.Text = "Gender";
			this.rbGender.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// rbMale
			// 
			this.rbMale.AutoSize = true;
			this.rbMale.Location = new System.Drawing.Point(119, 101);
			this.rbMale.Name = "rbMale";
			this.rbMale.Size = new System.Drawing.Size(51, 19);
			this.rbMale.TabIndex = 13;
			this.rbMale.TabStop = true;
			this.rbMale.Text = "Male";
			this.rbMale.UseVisualStyleBackColor = true;
			// 
			// rbFemale
			// 
			this.rbFemale.AutoSize = true;
			this.rbFemale.Location = new System.Drawing.Point(176, 101);
			this.rbFemale.Name = "rbFemale";
			this.rbFemale.Size = new System.Drawing.Size(63, 19);
			this.rbFemale.TabIndex = 14;
			this.rbFemale.TabStop = true;
			this.rbFemale.Text = "Female";
			this.rbFemale.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 145);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 15);
			this.label4.TabIndex = 15;
			this.label4.Text = "Address";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(119, 142);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(100, 23);
			this.txtAddress.TabIndex = 16;
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(45, 63);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 23);
			this.txtId.TabIndex = 18;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnUpdate);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.txtFName);
			this.panel1.Controls.Add(this.txtAddress);
			this.panel1.Controls.Add(this.txtLName);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.rbFemale);
			this.panel1.Controls.Add(this.rbGender);
			this.panel1.Controls.Add(this.rbMale);
			this.panel1.Location = new System.Drawing.Point(44, 117);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(377, 284);
			this.panel1.TabIndex = 20;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(289, 205);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 26);
			this.btnClear.TabIndex = 19;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(192, 205);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 26);
			this.btnDelete.TabIndex = 18;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(97, 205);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 26);
			this.btnUpdate.TabIndex = 17;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(163, 60);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 26);
			this.btnSearch.TabIndex = 17;
			this.btnSearch.Text = "Search ID";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// FrmCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 468);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label3);
			this.Name = "FrmCustomer";
			this.Text = "FrmCustomer";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label2;
		private TextBox txtLName;
		private TextBox txtFName;
		private Button btnAdd;
		private Label label3;
		private Label label1;
		private Label rbGender;
		private RadioButton rbMale;
		private RadioButton rbFemale;
		private Label label4;
		private TextBox txtAddress;
		private TextBox txtId;
		private Panel panel1;
		private Button btnSearch;
		private Button btnDelete;
		private Button btnUpdate;
		private Button btnClear;
	}
}