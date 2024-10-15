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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.allStaffListBox = new System.Windows.Forms.ListBox();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.listBox4 = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.listBox5 = new System.Windows.Forms.ListBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
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
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(103, 25);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(144, 17);
			this.listBox1.TabIndex = 3;
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
			// allStaffListBox
			// 
			this.allStaffListBox.FormattingEnabled = true;
			this.allStaffListBox.Location = new System.Drawing.Point(25, 105);
			this.allStaffListBox.Name = "allStaffListBox";
			this.allStaffListBox.Size = new System.Drawing.Size(393, 69);
			this.allStaffListBox.TabIndex = 5;
			// 
			// listBox3
			// 
			this.listBox3.FormattingEnabled = true;
			this.listBox3.Location = new System.Drawing.Point(25, 234);
			this.listBox3.Name = "listBox3";
			this.listBox3.Size = new System.Drawing.Size(393, 69);
			this.listBox3.TabIndex = 6;
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
			// listBox4
			// 
			this.listBox4.FormattingEnabled = true;
			this.listBox4.Location = new System.Drawing.Point(69, 344);
			this.listBox4.Name = "listBox4";
			this.listBox4.Size = new System.Drawing.Size(144, 17);
			this.listBox4.TabIndex = 9;
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
			// listBox5
			// 
			this.listBox5.FormattingEnabled = true;
			this.listBox5.Location = new System.Drawing.Point(285, 342);
			this.listBox5.Name = "listBox5";
			this.listBox5.Size = new System.Drawing.Size(144, 17);
			this.listBox5.TabIndex = 11;
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
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 428);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(106, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Displaying X records.";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 450);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.listBox5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.listBox4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listBox3);
			this.Controls.Add(this.allStaffListBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox1);
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
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox listBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox listBox5;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListBox allStaffListBox;
	}
}

