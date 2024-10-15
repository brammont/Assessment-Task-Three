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
			this.FilterButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lstAllRecords = new System.Windows.Forms.ListBox();
			this.lstFilteredRecords = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
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
			// FilterButton
			// 
			this.FilterButton.Location = new System.Drawing.Point(268, 23);
			this.FilterButton.Name = "FilterButton";
			this.FilterButton.Size = new System.Drawing.Size(75, 23);
			this.FilterButton.TabIndex = 1;
			this.FilterButton.Text = "Filter";
			this.FilterButton.UseVisualStyleBackColor = true;
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
			this.lstFilteredRecords.Location = new System.Drawing.Point(25, 234);
			this.lstFilteredRecords.Name = "lstFilteredRecords";
			this.lstFilteredRecords.Size = new System.Drawing.Size(393, 69);
			this.lstFilteredRecords.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 217);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Filtered Results:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 347);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Staff ID:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(231, 345);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Name:";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(25, 395);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 12;
			this.button3.Text = "Open Admin GUI";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.UseVisualStyleBackColor = true;
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(22, 428);
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
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(89, 340);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 15;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(287, 342);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 16;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 450);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.txtFilter);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lstFilteredRecords);
			this.Controls.Add(this.lstAllRecords);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.FilterButton);
			this.Controls.Add(this.loadButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button loadButton;
		private System.Windows.Forms.Button FilterButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lstFilteredRecords;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.ListBox lstAllRecords;
		private System.Windows.Forms.TextBox txtFilter;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
	}
}

