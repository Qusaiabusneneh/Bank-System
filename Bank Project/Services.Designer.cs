namespace Bank_Project
{
    partial class Services
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
            this.components = new System.ComponentModel.Container();
            this.ClinetMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UserMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TransactionMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.cmbTransaction = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TSMAddNewClient = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMDeleteClient = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMUpdateClient = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMFindClinet = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMUpdateUSer = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMFindUser = new System.Windows.Forms.ToolStripMenuItem();
            this.clientTransationINFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMDeposit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMWithdraw = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMTotalBalance = new System.Windows.Forms.ToolStripMenuItem();
            this.ClinetMenuStrip.SuspendLayout();
            this.UserMenuStrip.SuspendLayout();
            this.TransactionMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClinetMenuStrip
            // 
            this.ClinetMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ClinetMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMAddNewClient,
            this.TSMDeleteClient,
            this.TSMUpdateClient,
            this.TSMFindClinet});
            this.ClinetMenuStrip.Name = "ClinetMenuStrip";
            this.ClinetMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ClinetMenuStrip.Size = new System.Drawing.Size(166, 124);
            // 
            // UserMenuStrip
            // 
            this.UserMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.UserMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMAddUser,
            this.TSMDeleteUser,
            this.TSMUpdateUSer,
            this.TSMFindUser,
            this.clientTransationINFOToolStripMenuItem});
            this.UserMenuStrip.Name = "UserMenuStrip2";
            this.UserMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.UserMenuStrip.Size = new System.Drawing.Size(201, 176);
            // 
            // TransactionMenuStrip
            // 
            this.TransactionMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TransactionMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMDeposit,
            this.TSMWithdraw,
            this.TSMTotalBalance});
            this.TransactionMenuStrip.Name = "TransactionMenuStrip1";
            this.TransactionMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TransactionMenuStrip.Size = new System.Drawing.Size(152, 94);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(71, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(375, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(604, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Transaction";
            // 
            // cmbClient
            // 
            this.cmbClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbClient.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbClient.Items.AddRange(new object[] {
            "Add New Client",
            "Delete Client",
            "Update Client",
            "Find Client"});
            this.cmbClient.Location = new System.Drawing.Point(42, 292);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(126, 23);
            this.cmbClient.TabIndex = 9;
            this.cmbClient.Text = "    Client Menue";
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            // 
            // cmbUser
            // 
            this.cmbUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbUser.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Items.AddRange(new object[] {
            "Add New User",
            "Delete  User",
            "Update User",
            "Find User",
            "INFO Client,Transaction"});
            this.cmbUser.Location = new System.Drawing.Point(345, 292);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(121, 23);
            this.cmbUser.TabIndex = 10;
            this.cmbUser.Text = "     User Menue";
            this.cmbUser.SelectedIndexChanged += new System.EventHandler(this.cmbUser_SelectedIndexChanged);
            // 
            // cmbTransaction
            // 
            this.cmbTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTransaction.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTransaction.FormattingEnabled = true;
            this.cmbTransaction.Items.AddRange(new object[] {
            "Deposit ",
            "Withdraw",
            "Total Balance"});
            this.cmbTransaction.Location = new System.Drawing.Point(622, 292);
            this.cmbTransaction.Name = "cmbTransaction";
            this.cmbTransaction.Size = new System.Drawing.Size(145, 23);
            this.cmbTransaction.TabIndex = 11;
            this.cmbTransaction.Text = "Transaction Menue";
            this.cmbTransaction.SelectedIndexChanged += new System.EventHandler(this.cmbTransaction_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.ContextMenuStrip = this.TransactionMenuStrip;
            this.pictureBox3.Image = global::Bank_Project.Properties.Resources.Transaction;
            this.pictureBox3.Location = new System.Drawing.Point(578, 55);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(210, 219);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ContextMenuStrip = this.ClinetMenuStrip;
            this.pictureBox2.Image = global::Bank_Project.Properties.Resources.Add_New_User;
            this.pictureBox2.Location = new System.Drawing.Point(12, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(215, 219);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.UserMenuStrip;
            this.pictureBox1.Image = global::Bank_Project.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(303, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TSMAddNewClient
            // 
            this.TSMAddNewClient.Image = global::Bank_Project.Properties.Resources.Add_New_User1;
            this.TSMAddNewClient.Name = "TSMAddNewClient";
            this.TSMAddNewClient.Size = new System.Drawing.Size(165, 30);
            this.TSMAddNewClient.Text = "Add New Client";
            this.TSMAddNewClient.Click += new System.EventHandler(this.TSMAddNewClient_Click);
            // 
            // TSMDeleteClient
            // 
            this.TSMDeleteClient.Image = global::Bank_Project.Properties.Resources.Delete;
            this.TSMDeleteClient.Name = "TSMDeleteClient";
            this.TSMDeleteClient.Size = new System.Drawing.Size(165, 30);
            this.TSMDeleteClient.Text = "Delete Client";
            this.TSMDeleteClient.Click += new System.EventHandler(this.TSMDeleteClient_Click);
            // 
            // TSMUpdateClient
            // 
            this.TSMUpdateClient.Image = global::Bank_Project.Properties.Resources.Update;
            this.TSMUpdateClient.Name = "TSMUpdateClient";
            this.TSMUpdateClient.Size = new System.Drawing.Size(165, 30);
            this.TSMUpdateClient.Text = "Update Clinet";
            this.TSMUpdateClient.Click += new System.EventHandler(this.TSMUpdateClient_Click);
            // 
            // TSMFindClinet
            // 
            this.TSMFindClinet.Image = global::Bank_Project.Properties.Resources.Search;
            this.TSMFindClinet.Name = "TSMFindClinet";
            this.TSMFindClinet.Size = new System.Drawing.Size(165, 30);
            this.TSMFindClinet.Text = "Find Clinet";
            this.TSMFindClinet.Click += new System.EventHandler(this.TSMFindClinet_Click);
            // 
            // TSMAddUser
            // 
            this.TSMAddUser.Image = global::Bank_Project.Properties.Resources.User;
            this.TSMAddUser.Name = "TSMAddUser";
            this.TSMAddUser.Size = new System.Drawing.Size(200, 30);
            this.TSMAddUser.Text = "Add New User";
            this.TSMAddUser.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // TSMDeleteUser
            // 
            this.TSMDeleteUser.Image = global::Bank_Project.Properties.Resources.Delete;
            this.TSMDeleteUser.Name = "TSMDeleteUser";
            this.TSMDeleteUser.Size = new System.Drawing.Size(200, 30);
            this.TSMDeleteUser.Text = "Delete User";
            this.TSMDeleteUser.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // TSMUpdateUSer
            // 
            this.TSMUpdateUSer.Image = global::Bank_Project.Properties.Resources.Update;
            this.TSMUpdateUSer.Name = "TSMUpdateUSer";
            this.TSMUpdateUSer.Size = new System.Drawing.Size(200, 30);
            this.TSMUpdateUSer.Text = "Update User";
            this.TSMUpdateUSer.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
            // 
            // TSMFindUser
            // 
            this.TSMFindUser.Image = global::Bank_Project.Properties.Resources.Search;
            this.TSMFindUser.Name = "TSMFindUser";
            this.TSMFindUser.Size = new System.Drawing.Size(200, 30);
            this.TSMFindUser.Text = "Find User";
            this.TSMFindUser.Click += new System.EventHandler(this.findUserToolStripMenuItem_Click);
            // 
            // clientTransationINFOToolStripMenuItem
            // 
            this.clientTransationINFOToolStripMenuItem.Image = global::Bank_Project.Properties.Resources.World;
            this.clientTransationINFOToolStripMenuItem.Name = "clientTransationINFOToolStripMenuItem";
            this.clientTransationINFOToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.clientTransationINFOToolStripMenuItem.Text = "Client,Transation INFO";
            this.clientTransationINFOToolStripMenuItem.Click += new System.EventHandler(this.clientTransationINFOToolStripMenuItem_Click);
            // 
            // TSMDeposit
            // 
            this.TSMDeposit.Image = global::Bank_Project.Properties.Resources.Deposit;
            this.TSMDeposit.Name = "TSMDeposit";
            this.TSMDeposit.Size = new System.Drawing.Size(151, 30);
            this.TSMDeposit.Text = "Deposit";
            this.TSMDeposit.Click += new System.EventHandler(this.TSMDeposit_Click);
            // 
            // TSMWithdraw
            // 
            this.TSMWithdraw.Image = global::Bank_Project.Properties.Resources.Withdraw;
            this.TSMWithdraw.Name = "TSMWithdraw";
            this.TSMWithdraw.Size = new System.Drawing.Size(151, 30);
            this.TSMWithdraw.Text = "Withdraw";
            this.TSMWithdraw.Click += new System.EventHandler(this.TSMWithdraw_Click);
            // 
            // TSMTotalBalance
            // 
            this.TSMTotalBalance.Image = global::Bank_Project.Properties.Resources.Total;
            this.TSMTotalBalance.Name = "TSMTotalBalance";
            this.TSMTotalBalance.Size = new System.Drawing.Size(151, 30);
            this.TSMTotalBalance.Text = "Total Balance";
            this.TSMTotalBalance.Click += new System.EventHandler(this.TSMTotalBalance_Click);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbTransaction);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Services";
            this.Text = "Services";
            this.ClinetMenuStrip.ResumeLayout(false);
            this.UserMenuStrip.ResumeLayout(false);
            this.TransactionMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip ClinetMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TSMAddNewClient;
        private System.Windows.Forms.ToolStripMenuItem TSMDeleteClient;
        private System.Windows.Forms.ToolStripMenuItem TSMUpdateClient;
        private System.Windows.Forms.ToolStripMenuItem TSMFindClinet;
        private System.Windows.Forms.ContextMenuStrip UserMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TSMAddUser;
        private System.Windows.Forms.ToolStripMenuItem TSMDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem TSMUpdateUSer;
        private System.Windows.Forms.ToolStripMenuItem TSMFindUser;
        private System.Windows.Forms.ContextMenuStrip TransactionMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TSMDeposit;
        private System.Windows.Forms.ToolStripMenuItem TSMWithdraw;
        private System.Windows.Forms.ToolStripMenuItem TSMTotalBalance;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.ComboBox cmbTransaction;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.ToolStripMenuItem clientTransationINFOToolStripMenuItem;
    }
}