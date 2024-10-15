namespace MSSS_StaffManagementApp_
{
	partial class AdminForm
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
			this.btnCreate = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAdminID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAdminName = new System.Windows.Forms.TextBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.lblAdminStatus = new System.Windows.Forms.Label();
			this.btnOpenMain = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(33, 99);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(75, 23);
			this.btnCreate.TabIndex = 0;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Staff ID:";
			// 
			// txtAdminID
			// 
			this.txtAdminID.Location = new System.Drawing.Point(118, 42);
			this.txtAdminID.Name = "txtAdminID";
			this.txtAdminID.Size = new System.Drawing.Size(100, 20);
			this.txtAdminID.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(241, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Name:";
			// 
			// txtAdminName
			// 
			this.txtAdminName.Location = new System.Drawing.Point(285, 42);
			this.txtAdminName.Name = "txtAdminName";
			this.txtAdminName.Size = new System.Drawing.Size(100, 20);
			this.txtAdminName.TabIndex = 6;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(118, 99);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(204, 99);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// lblAdminStatus
			// 
			this.lblAdminStatus.AutoSize = true;
			this.lblAdminStatus.Location = new System.Drawing.Point(30, 146);
			this.lblAdminStatus.Name = "lblAdminStatus";
			this.lblAdminStatus.Size = new System.Drawing.Size(88, 13);
			this.lblAdminStatus.TabIndex = 9;
			this.lblAdminStatus.Text = "Ready for action.";
			// 
			// btnOpenMain
			// 
			this.btnOpenMain.Location = new System.Drawing.Point(33, 162);
			this.btnOpenMain.Name = "btnOpenMain";
			this.btnOpenMain.Size = new System.Drawing.Size(105, 23);
			this.btnOpenMain.TabIndex = 10;
			this.btnOpenMain.Text = "Back to General GUI";
			this.btnOpenMain.UseVisualStyleBackColor = true;
			this.btnOpenMain.Click += new System.EventHandler(this.btnOpenMain_Click);
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 191);
			this.Controls.Add(this.btnOpenMain);
			this.Controls.Add(this.lblAdminStatus);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.txtAdminName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtAdminID);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCreate);
			this.Name = "AdminForm";
			this.Text = "AdminForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAdminID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAdminName;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label lblAdminStatus;
		private System.Windows.Forms.Button btnOpenMain;
	}
}