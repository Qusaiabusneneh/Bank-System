namespace Bank_Project
{
    partial class Add_User
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.grpPermission = new System.Windows.Forms.GroupBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.chkMangeUser = new System.Windows.Forms.CheckBox();
            this.chkTransaction = new System.Windows.Forms.CheckBox();
            this.chkFindClient = new System.Windows.Forms.CheckBox();
            this.chkUpdateClient = new System.Windows.Forms.CheckBox();
            this.chkDeleteClient = new System.Windows.Forms.CheckBox();
            this.chkAddClient = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpPermission.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Bank_Project.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(234, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add User Screen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(100, 114);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(84, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(100, 146);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(84, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // grpPermission
            // 
            this.grpPermission.Controls.Add(this.chkAll);
            this.grpPermission.Controls.Add(this.chkMangeUser);
            this.grpPermission.Controls.Add(this.chkTransaction);
            this.grpPermission.Controls.Add(this.chkFindClient);
            this.grpPermission.Controls.Add(this.chkUpdateClient);
            this.grpPermission.Controls.Add(this.chkDeleteClient);
            this.grpPermission.Controls.Add(this.chkAddClient);
            this.grpPermission.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPermission.Location = new System.Drawing.Point(1, 172);
            this.grpPermission.Name = "grpPermission";
            this.grpPermission.Size = new System.Drawing.Size(229, 119);
            this.grpPermission.TabIndex = 10;
            this.grpPermission.TabStop = false;
            this.grpPermission.Text = "Permission";
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(6, 98);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(43, 19);
            this.chkAll.TabIndex = 17;
            this.chkAll.Tag = "-1";
            this.chkAll.Text = "All";
            this.chkAll.UseVisualStyleBackColor = true;
            // 
            // chkMangeUser
            // 
            this.chkMangeUser.AutoSize = true;
            this.chkMangeUser.Location = new System.Drawing.Point(113, 73);
            this.chkMangeUser.Name = "chkMangeUser";
            this.chkMangeUser.Size = new System.Drawing.Size(103, 19);
            this.chkMangeUser.TabIndex = 16;
            this.chkMangeUser.Tag = "32";
            this.chkMangeUser.Text = "Manage User";
            this.chkMangeUser.UseVisualStyleBackColor = true;
            // 
            // chkTransaction
            // 
            this.chkTransaction.AutoSize = true;
            this.chkTransaction.Location = new System.Drawing.Point(6, 73);
            this.chkTransaction.Name = "chkTransaction";
            this.chkTransaction.Size = new System.Drawing.Size(97, 19);
            this.chkTransaction.TabIndex = 15;
            this.chkTransaction.Tag = "16";
            this.chkTransaction.Text = "Transaction";
            this.chkTransaction.UseVisualStyleBackColor = true;
            // 
            // chkFindClient
            // 
            this.chkFindClient.AutoSize = true;
            this.chkFindClient.Location = new System.Drawing.Point(112, 47);
            this.chkFindClient.Name = "chkFindClient";
            this.chkFindClient.Size = new System.Drawing.Size(87, 19);
            this.chkFindClient.TabIndex = 14;
            this.chkFindClient.Tag = "8";
            this.chkFindClient.Text = "FindClient";
            this.chkFindClient.UseVisualStyleBackColor = true;
            // 
            // chkUpdateClient
            // 
            this.chkUpdateClient.AutoSize = true;
            this.chkUpdateClient.Location = new System.Drawing.Point(6, 47);
            this.chkUpdateClient.Name = "chkUpdateClient";
            this.chkUpdateClient.Size = new System.Drawing.Size(104, 19);
            this.chkUpdateClient.TabIndex = 13;
            this.chkUpdateClient.Tag = "4";
            this.chkUpdateClient.Text = "UpdateClient";
            this.chkUpdateClient.UseVisualStyleBackColor = true;
            // 
            // chkDeleteClient
            // 
            this.chkDeleteClient.AutoSize = true;
            this.chkDeleteClient.Location = new System.Drawing.Point(112, 22);
            this.chkDeleteClient.Name = "chkDeleteClient";
            this.chkDeleteClient.Size = new System.Drawing.Size(105, 19);
            this.chkDeleteClient.TabIndex = 12;
            this.chkDeleteClient.Tag = "2";
            this.chkDeleteClient.Text = "Delete Client";
            this.chkDeleteClient.UseVisualStyleBackColor = true;
            // 
            // chkAddClient
            // 
            this.chkAddClient.AutoSize = true;
            this.chkAddClient.Location = new System.Drawing.Point(6, 22);
            this.chkAddClient.Name = "chkAddClient";
            this.chkAddClient.Size = new System.Drawing.Size(85, 19);
            this.chkAddClient.TabIndex = 11;
            this.chkAddClient.Tag = "1";
            this.chkAddClient.Text = "AddClient";
            this.chkAddClient.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(54, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 36);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Add_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpPermission);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Add_User";
            this.Text = "Add_User";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpPermission.ResumeLayout(false);
            this.grpPermission.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox grpPermission;
        private System.Windows.Forms.CheckBox chkUpdateClient;
        private System.Windows.Forms.CheckBox chkDeleteClient;
        private System.Windows.Forms.CheckBox chkAddClient;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.CheckBox chkMangeUser;
        private System.Windows.Forms.CheckBox chkTransaction;
        private System.Windows.Forms.CheckBox chkFindClient;
        private System.Windows.Forms.Button btnSave;
    }
}