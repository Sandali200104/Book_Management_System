namespace Book_Management_System
{
	partial class FrmBooks
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
			this.txtBookName = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmbBookType = new System.Windows.Forms.ComboBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(189, 33);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 26);
			this.btnSearch.TabIndex = 22;
			this.btnSearch.Text = "Search ID";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(292, 107);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 26);
			this.btnClear.TabIndex = 19;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(195, 107);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 26);
			this.btnDelete.TabIndex = 18;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 15);
			this.label1.TabIndex = 11;
			this.label1.Text = "Book Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(7, 107);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 26);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtBookName
			// 
			this.txtBookName.Location = new System.Drawing.Point(119, 17);
			this.txtBookName.Name = "txtBookName";
			this.txtBookName.Size = new System.Drawing.Size(121, 23);
			this.txtBookName.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cmbBookType);
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnUpdate);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.txtBookName);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(71, 87);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(375, 163);
			this.panel1.TabIndex = 24;
			// 
			// cmbBookType
			// 
			this.cmbBookType.FormattingEnabled = true;
			this.cmbBookType.Items.AddRange(new object[] {
            "Classics",
            "Fantasy",
            "Comic ",
            "Historical "});
			this.cmbBookType.Location = new System.Drawing.Point(119, 61);
			this.cmbBookType.Name = "cmbBookType";
			this.cmbBookType.Size = new System.Drawing.Size(121, 23);
			this.cmbBookType.TabIndex = 20;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(100, 107);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 26);
			this.btnUpdate.TabIndex = 17;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 15);
			this.label2.TabIndex = 9;
			this.label2.Text = "Book Type";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(71, 36);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 23);
			this.txtId.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(134, 7);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 15);
			this.label3.TabIndex = 21;
			this.label3.Text = "Books";
			// 
			// FrmBooks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(517, 374);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label3);
			this.Name = "FrmBooks";
			this.Text = "FrmBooks";
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
		private TextBox txtBookName;
		private Panel panel1;
		private ComboBox cmbBookType;
		private Button btnUpdate;
		private Label label2;
		private TextBox txtId;
		private Label label3;
	}
}