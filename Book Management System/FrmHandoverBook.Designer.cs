namespace Book_Management_System
{
	partial class FrmHandoverBook
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
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtHandoverId = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtBookName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbBookType = new System.Windows.Forms.ComboBox();
			this.HandoverDate = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.txtCustomerId = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(142, 53);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 26);
			this.btnSearch.TabIndex = 26;
			this.btnSearch.Text = "Search ID";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(289, 227);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 26);
			this.btnClear.TabIndex = 19;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(192, 227);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 26);
			this.btnDelete.TabIndex = 18;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 15);
			this.label1.TabIndex = 11;
			this.label1.Text = "Handover Id";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(4, 227);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 26);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtHandoverId
			// 
			this.txtHandoverId.Location = new System.Drawing.Point(119, 17);
			this.txtHandoverId.Name = "txtHandoverId";
			this.txtHandoverId.Size = new System.Drawing.Size(100, 23);
			this.txtHandoverId.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtBookName);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.cmbBookType);
			this.panel1.Controls.Add(this.HandoverDate);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnUpdate);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.txtHandoverId);
			this.panel1.Controls.Add(this.txtCustomerId);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(23, 110);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(377, 284);
			this.panel1.TabIndex = 28;
			// 
			// txtBookName
			// 
			this.txtBookName.Location = new System.Drawing.Point(118, 138);
			this.txtBookName.Name = "txtBookName";
			this.txtBookName.Size = new System.Drawing.Size(100, 23);
			this.txtBookName.TabIndex = 24;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 140);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 15);
			this.label6.TabIndex = 23;
			this.label6.Text = "Book Name";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// cmbBookType
			// 
			this.cmbBookType.FormattingEnabled = true;
			this.cmbBookType.Items.AddRange(new object[] {
            "Classics",
            "Fantasy",
            "Comic ",
            "Historical"});
			this.cmbBookType.Location = new System.Drawing.Point(119, 98);
			this.cmbBookType.Name = "cmbBookType";
			this.cmbBookType.Size = new System.Drawing.Size(121, 23);
			this.cmbBookType.TabIndex = 22;
			// 
			// HandoverDate
			// 
			this.HandoverDate.Location = new System.Drawing.Point(119, 184);
			this.HandoverDate.Name = "HandoverDate";
			this.HandoverDate.Size = new System.Drawing.Size(200, 23);
			this.HandoverDate.TabIndex = 21;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 189);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 15);
			this.label5.TabIndex = 20;
			this.label5.Text = "Date";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(97, 227);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 26);
			this.btnUpdate.TabIndex = 17;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// txtCustomerId
			// 
			this.txtCustomerId.Location = new System.Drawing.Point(119, 54);
			this.txtCustomerId.Name = "txtCustomerId";
			this.txtCustomerId.Size = new System.Drawing.Size(100, 23);
			this.txtCustomerId.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 57);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 15);
			this.label4.TabIndex = 15;
			this.label4.Text = "Customer Id";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 15);
			this.label2.TabIndex = 9;
			this.label2.Text = "Book Type";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(24, 56);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 23);
			this.txtId.TabIndex = 27;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(87, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 15);
			this.label3.TabIndex = 25;
			this.label3.Text = "Handover Book";
			// 
			// FrmHandoverBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label3);
			this.Name = "FrmHandoverBook";
			this.Text = "FrmHandoverBook";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnSearch;
		private Button btnClear;
		private Button btnDelete;
		private Label label1;
		private Button btnAdd;
		private TextBox txtHandoverId;
		private Panel panel1;
		private TextBox txtBookName;
		private Label label6;
		private ComboBox cmbBookType;
		private DateTimePicker HandoverDate;
		private Label label5;
		private Button btnUpdate;
		private TextBox txtCustomerId;
		private Label label4;
		private Label label2;
		private TextBox txtId;
		private Label label3;
	}
}