namespace MSSS_StaffManagementApp_
{
	partial class Form1
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
			this.loadButton = new System.Windows.Forms.Button();
			this.btnFilter = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lstAllRecords = new System.Windows.Forms.ListBox();
			this.lstFilteredRecords = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnOpenAdmin = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.UserTextBox = new System.Windows.Forms.TextBox();
			this.pwdTextBox = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// loadButton
			// 
			this.loadButton.Location = new System.Drawing.Point(12, 23);
			this.loadButton.Name = "loadButton";
			this.loadButton.Size = new System.Drawing.Size(75, 23);
			this.loadButton.TabIndex = 0;
			this.loadButton.Text = "Load Data";
			this.loadButton.UseVisualStyleBackColor = true;
			this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
			// 
			// btnFilter
			// 
			this.btnFilter.Location = new System.Drawing.Point(268, 23);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(75, 23);
			this.btnFilter.TabIndex = 1;
			this.btnFilter.Text = "Filter";
			this.btnFilter.UseVisualStyleBackColor = true;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "All Staff Records:";
			// 
			// lstAllRecords
			// 
			this.lstAllRecords.FormattingEnabled = true;
			this.lstAllRecords.Location = new System.Drawing.Point(25, 105);
			this.lstAllRecords.Name = "lstAllRecords";
			this.lstAllRecords.Size = new System.Drawing.Size(393, 69);
			this.lstAllRecords.TabIndex = 5;
			// 
			// lstFilteredRecords
			// 
			this.lstFilteredRecords.FormattingEnabled = true;
			this.lstFilteredRecords.Location = new System.Drawing.Point(25, 269);
			this.lstFilteredRecords.Name = "lstFilteredRecords";
			this.lstFilteredRecords.Size = new System.Drawing.Size(393, 69);
			this.lstFilteredRecords.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 253);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Filtered Results:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 372);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "User:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(231, 369);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Password:";
			// 
			// btnOpenAdmin
			// 
			this.btnOpenAdmin.Location = new System.Drawing.Point(36, 405);
			this.btnOpenAdmin.Name = "btnOpenAdmin";
			this.btnOpenAdmin.Size = new System.Drawing.Size(75, 23);
			this.btnOpenAdmin.TabIndex = 12;
			this.btnOpenAdmin.Text = "Open Admin GUI";
			this.btnOpenAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOpenAdmin.UseVisualStyleBackColor = true;
			this.btnOpenAdmin.Click += new System.EventHandler(this.btnOpenAdmin_Click);
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(231, 415);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(106, 13);
			this.lblStatus.TabIndex = 13;
			this.lblStatus.Text = "Displaying X records.";
			// 
			// txtFilter
			// 
			this.txtFilter.Location = new System.Drawing.Point(103, 26);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(143, 20);
			this.txtFilter.TabIndex = 14;
			// 
			// UserTextBox
			// 
			this.UserTextBox.Location = new System.Drawing.Point(81, 369);
			this.UserTextBox.Name = "UserTextBox";
			this.UserTextBox.Size = new System.Drawing.Size(100, 20);
			this.UserTextBox.TabIndex = 15;
			// 
			// pwdTextBox
			// 
			this.pwdTextBox.Location = new System.Drawing.Point(290, 372);
			this.pwdTextBox.Name = "pwdTextBox";
			this.pwdTextBox.PasswordChar = '*';
			this.pwdTextBox.Size = new System.Drawing.Size(100, 20);
			this.pwdTextBox.TabIndex = 16;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(124, 215);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 17;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(243, 215);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 18;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 450);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.pwdTextBox);
			this.Controls.Add(this.UserTextBox);
			this.Controls.Add(this.txtFilter);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.btnOpenAdmin);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lstFilteredRecords);
			this.Controls.Add(this.lstAllRecords);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnFilter);
			this.Controls.Add(this.loadButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button loadButton;
		private System.Windows.Forms.Button btnFilter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lstFilteredRecords;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnOpenAdmin;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.ListBox lstAllRecords;
		private System.Windows.Forms.TextBox txtFilter;
		private System.Windows.Forms.TextBox UserTextBox;
		private System.Windows.Forms.TextBox pwdTextBox;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
	}
}

